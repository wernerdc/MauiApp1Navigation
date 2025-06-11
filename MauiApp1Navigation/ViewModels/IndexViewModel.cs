using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1Navigation.ViewModels
{
    [QueryProperty(nameof(IsNew), "new")]           // mapping the query parameter "new" to the IsNew property
    [QueryProperty(nameof(Profile), "profile")]     // mapping the query parameter "profile" to the Profile property
    public partial class IndexViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isNew;

        [ObservableProperty]
        private Entities.Profile _profile;

        public string Greeting => IsNew
            ? $"Welcome, {Profile?.Name}!"
            : $"Hello, {Profile?.Name}!";

        [RelayCommand]
        private async Task ViewAddress()
        {
            await Shell.Current.GoToAsync($"address?address={Profile.Address}");      // passing Address string as a query parameter
            //await Shell.Current.GoToAsync($"//profileaddress");   
        }

        partial void OnIsNewChanged(bool value)
        {
            OnPropertyChanged(nameof(Greeting));
        }

        partial void OnProfileChanged(Entities.Profile value)
        {
            OnPropertyChanged(nameof(Greeting));
        }
    }
}