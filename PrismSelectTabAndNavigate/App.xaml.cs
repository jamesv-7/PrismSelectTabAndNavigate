using FreshMvvm.Maui;
using PrismSelectTabAndNavigate.ViewModels;

namespace PrismSelectTabAndNavigate;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        var TabbedPageContainer = new FreshTabbedNavigationContainer();
        TabbedPageContainer.AddTab<Tab1PageModel>("Dashboard", null);
        TabbedPageContainer.AddTab<Tab2PageModel>("MedChest", null);
        TabbedPageContainer.AddTab<Tab3PageViewModel>("MedChest", null);
        MainPage = TabbedPageContainer;
        //MainPage = new AppShell();
    }
}

