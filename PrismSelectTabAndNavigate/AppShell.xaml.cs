using PrismSelectTabAndNavigate.Pages;
using PrismSelectTabAndNavigate.Services;

namespace PrismSelectTabAndNavigate;


public partial class AppShell : Shell
{
    private readonly INavigationService navigationService;
    public static string FromPage;
    public static string ToPage;
    public static string NavigationSource;
    public static DateTime SleepTime;
    public static bool ApiComplete = false;


    public AppShell(INavigationService navigationService)
    {
        this.navigationService = navigationService;
        InitializeComponent();
        Routing.RegisterRoute(nameof(Tab1Page), typeof(Tab1Page));
        Routing.RegisterRoute(nameof(Tab2Page), typeof(Tab2Page));
        Routing.RegisterRoute(nameof(Tab3Page), typeof(Tab3Page));
        Routing.RegisterRoute(nameof(Tab4Page), typeof(Tab4Page));
        Routing.RegisterRoute(nameof(MoreMenuPage), typeof(MoreMenuPage));
        Routing.RegisterRoute(nameof(CreateAccountPage), typeof(CreateAccountPage));

    }
    protected override void OnNavigating(ShellNavigatingEventArgs args)
    {
        base.OnNavigating(args);

        try
        {
            if (args != null)
            {
                App.NavigationSoure = args?.Source.ToString();
                //var current = args.Current?.Location.ToString();
                //App.FromPage = current;
                //var target = args.Target?.Location.ToString();
                //App.ToPage = target;
                //if (MainNavBar.Instance != null)
                //{
                //    MainNavBar.Instance.ClearButtons();

                //}

            }

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.Write(ex.Message);
        }
    }

    void Tab_Appearing(System.Object sender, System.EventArgs e)
    {
        //(sender as Tab).Icon = "dotnet_bot.png";

    }

}


