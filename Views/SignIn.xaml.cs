using System.Text.Json;
using System.Text;

namespace HelloWorldApp.Views;

public partial class SignIn : ContentPage
{
    public SignIn()
    {
        InitializeComponent();
    }
    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        string apiEndpoint = "https://localhost:7272/user/register"; // API URL
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
                ApiResponseLabel.Text = "Registration successful: " + responseData;
            }
            else
            {
                string error = await response.Content.ReadAsStringAsync();
                ApiResponseLabel.Text = "Error: " + error;
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Failed to register: {ex.Message}", "OK");
        }
    }
}