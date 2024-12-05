namespace HelloWorldApp.Views;

public partial class Questao1 : ContentPage
{
	public Questao1()
	{
		InitializeComponent();
	}

    private async void Quiz1_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Quiz1());
    }
}