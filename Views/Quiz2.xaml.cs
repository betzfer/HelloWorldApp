namespace HelloWorldApp;

public partial class Quiz2 : ContentPage
{
	public bool programou;
	public Quiz2(bool recebeProgramou)
	{
		InitializeComponent();
		programou = recebeProgramou;
	}

    private async void Front_Clicked(object sender, EventArgs e)
    {
		bool front = true;
		await Navigation.PushAsync(new Quiz3(programou,front));
    }
}