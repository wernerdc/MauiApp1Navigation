namespace MauiApp1Navigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }

        protected override async void OnStart()
        {
            await Shell.Current.GoToAsync("//join");        // absolute navigation to the 'join' page by using the '//' prefix
            base.OnStart();
        }
    }
}