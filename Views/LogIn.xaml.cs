using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace HelloWorldApp
{
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string apiEndpoint = "https://localhost:7272/user/login?useCookies=false&useSessionCookies=false";
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Please fill in all fields.", "OK");
                return;
            }

            try
            {
                using HttpClient client = new();

                // Create the JSON payload
                var payload = new
                {
                    Username = username,
                    Password = password
                };

                string jsonPayload = JsonSerializer.Serialize(payload);
                StringContent content = new(jsonPayload, Encoding.UTF8, "application/json");

                // Send the POST request
                HttpResponseMessage response = await client.PostAsync(apiEndpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    ApiResponseLabel.Text = "Login successful: " + responseData;
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    ApiResponseLabel.Text = "Error: " + error;
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to log in: {ex.Message}", "OK");
            }
        }
    }
}
