using PrismSelectTabAndNavigate.Services;

namespace PrismSelectTabAndNavigate;

public partial class App : Application
{
    private readonly INavigationService _navigationService;
    public static string FromPage;
    public static string ToPage;
    public static string NavigationSoure;
    public static DateTime SleepTime;
    public static bool apiComplete = false;
    public static bool HasNotification = true;
    public static bool ShowLeaderLevel = true;
    public static bool ShowWeekCalendar = true;
    public static bool ShowAppTour = true;

    // public static List<NavButton> NavButtons;
    public static ImageButton OpenImageButton;
    public static ImageButton CloseImageButton;

    public static int SelectedIndex = 0;

    public App(INavigationService navigationService)
    {
        _navigationService = navigationService;

        InitializeComponent();

        MainPage = new AppShell(_navigationService);
        //MainPage = new AppShell();
    }
    protected override void OnStart()
    {

        base.OnStart();
    }

    protected override void OnSleep()
    {
        base.OnSleep();
        SleepTime = DateTime.Now;
    }
    protected override void OnResume()
    {
        base.OnResume();

    }
}

