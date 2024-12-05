using HelloWorldApp.Views;

namespace HelloWorldApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Quiz1());
        }
    }
}
