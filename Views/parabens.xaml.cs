namespace HelloWorldApp;

public partial class parabens : ContentPage
{
	public parabens()
	{
		InitializeComponent();
	}

    private async void Start_Agora(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StartPage());
    }
}