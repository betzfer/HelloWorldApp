namespace HelloWorldApp;

public partial class Quiz3 : ContentPage
{
	public bool Programou;
	public bool FrontBack;
	public Quiz3(bool recebeProgramou,bool recebeFrontBack)
	{
		InitializeComponent();
		Programou = recebeProgramou;
		FrontBack = recebeFrontBack;
	}

    private async void zero_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new parabens());
    }

    private async void um_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new parabens());
    }

    private async void dois_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new parabens());
    }
}