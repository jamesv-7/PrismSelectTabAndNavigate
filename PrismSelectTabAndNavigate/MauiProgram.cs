using System.Diagnostics;
using Microsoft.Extensions.Logging;
using PrismSelectTabAndNavigate.Pages;
using CommunityToolkit.Maui;
using FreshMvvm.Maui.Extensions;
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
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddTransient<MainTabbedPage>();
        builder.Services.AddTransient<Tab1Page>();
        builder.Services.AddTransient<Tab2Page>();
        builder.Services.AddTransient<Tab3Page>();
        builder.Services.AddTransient<Tab4Page>();
        builder.Services.AddTransient<CreateAccountPage>();
        builder.Services.AddTransient<MoreMenuPage>();

        builder.Services.AddTransient<Tab1PageModel>();
        builder.Services.AddTransient<Tab2PageModel>();
        builder.Services.AddTransient<Tab3PageViewModel>();
        builder.Services.AddTransient<Tab4PageViewModel>();
        builder.Services.AddTransient<CreateAccountPageViewModel>();
        builder.Services.AddTransient<MoreMenuViewModel>();

        MauiApp mauiApp = builder.Build();
        mauiApp.UseFreshMvvm();
        return mauiApp;
    }
}

