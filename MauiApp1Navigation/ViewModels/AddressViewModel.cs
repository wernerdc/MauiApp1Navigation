using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1Navigation.ViewModels
{
    [QueryProperty(nameof(Address), "address")]         // mapping the query parameter "address" to the Address property
    public partial class AddressViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _address;

        [RelayCommand]
        private async Task Back()
        {
            await Shell.Current.Navigation.PopAsync();
        }
    }
}