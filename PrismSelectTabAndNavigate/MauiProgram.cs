using System.Diagnostics;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using Microsoft.Extensions.Logging;
using PrismSelectTabAndNavigate.Pages;
using PrismSelectTabAndNavigate.Services;
using PrismSelectTabAndNavigate.ViewModels;

namespace PrismSelectTabAndNavigate;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitCore()

            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });



        builder.Services.AddSingleton<INavigationService, MauiNavigationService>();

        builder.Services.AddSingleton<Tab1Page>();
        builder.Services.AddSingleton<Tab1PageViewModel>();

        builder.Services.AddSingleton<Tab2Page>();
        builder.Services.AddSingleton<Tab2PageViewModel>();

        builder.Services.AddSingleton<Tab3Page>();
        builder.Services.AddSingleton<Tab3PageViewModel>();

        builder.Services.AddSingleton<Tab4Page>();
        builder.Services.AddSingleton<Tab4PageViewModel>();

        builder.Services.AddSingleton<MoreMenuPage>();
        builder.Services.AddSingleton<MoreMenuPageViewModel>();

        builder.Services.AddSingleton<CreateAccountPage>();
        builder.Services.AddSingleton<CreateAccountPageViewModel>();




#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    
        //prism.RegisterTypes(containerRegistry =>
        //{
        //    //containerRegistry.RegisterGlobalNavigationObserver();
        //    containerRegistry.RegisterForNavigation<MainTabbedPage>();
        //    containerRegistry.RegisterForNavigation<MainPage>();
        //    containerRegistry.RegisterForNavigation<Tab1Page>();
        //    containerRegistry.RegisterForNavigation<Tab2Page>();
        //    containerRegistry.RegisterForNavigation<MoreMenuPage>();
        //    containerRegistry.RegisterForNavigation<CreateAccountPage>();
        //    containerRegistry.RegisterForNavigation<Tab3Page>();
        //    containerRegistry.RegisterForNavigation<Tab4Page>();
        //    containerRegistry.RegisterForNavigation<SplashPage>();
        //}
    }
}

