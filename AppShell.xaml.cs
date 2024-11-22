namespace HelloWorldApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("SignIn", typeof(Views.SignIn));
        }
    }
}
