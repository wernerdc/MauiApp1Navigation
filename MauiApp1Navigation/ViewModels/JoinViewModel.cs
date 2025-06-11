using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1Navigation.ViewModels
{
    public partial class JoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name = "Julian";

        [ObservableProperty]
        private string _address = "123 Main St";

        [RelayCommand]
        private async Task Submit()
        {
            // Navigate to the Index page with named parameters in this dictionary of objects
            Dictionary<string, object> parameters = new Dictionary<string, object> 
            {
                { "new", true },
                { "profile", new Entities.Profile(Name, Address) }
            };

            await Shell.Current.GoToAsync("//profile", parameters);
        }
    }
}
