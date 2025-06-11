using MauiApp1Navigation.Pages.Profile;

namespace MauiApp1Navigation
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("profile/address", typeof(AddressView)); // Registering the sub route for the AddressView page
        }
    }
}
