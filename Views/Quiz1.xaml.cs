namespace HelloWorldApp;

public partial class Quiz1 : ContentPage
{
	public Quiz1()
	{
		InitializeComponent();
	}

    private async void Sim_Clicked(object sender, EventArgs e)
    {
        bool programou = true;
        await Navigation.PushAsync(new Quiz2(programou));
    }

    private async void Nao_Clicked(object sender, EventArgs e)
    {
        bool programou = false;
        await Navigation.PushAsync(new Quiz2(programou));
    }
}