﻿using MauiApp1Navigation.Pages;
using MauiApp1Navigation.Pages.Profile;
using MauiApp1Navigation.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiApp1Navigation
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddViewModel<JoinViewModel, JoinView>();
            builder.Services.AddViewModel<IndexViewModel, IndexView>();
            builder.Services.AddViewModel<AddressViewModel, AddressView>();

            return builder.Build();
        }

        private static void AddViewModel<TViewModel, TView>(this IServiceCollection services)
            where TView : ContentPage, new()
            where TViewModel : class
        {
            services.AddTransient<TViewModel>();
            services.AddTransient<TView>(s => new TView() { BindingContext = s.GetRequiredService<TViewModel>() });
        }
    }
}