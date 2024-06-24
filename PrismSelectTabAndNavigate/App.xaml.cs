using FreshMvvm.Maui;
using PrismSelectTabAndNavigate.ViewModels;

namespace PrismSelectTabAndNavigate;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        var TabbedPageContainer = new FreshTabbedNavigationContainer();
        TabbedPageContainer.AddTab<Tab1PageModel>("Tab 1", null);
        TabbedPageContainer.AddTab<Tab2PageModel>("Tab 2", null);
        TabbedPageContainer.AddTab<Tab3PageModel>("Tab 3", null);
        //TabbedPageContainer.AddTab<Tab4PageModel>("Tab 4", null);
        TabbedPageContainer.AddTab<MoreMenuPageModel>("More", null);
        MainPage = TabbedPageContainer;
        //MainPage = new AppShell();
    }
}

