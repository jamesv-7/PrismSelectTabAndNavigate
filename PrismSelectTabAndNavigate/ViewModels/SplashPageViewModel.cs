using System;
namespace PrismSelectTabAndNavigate.ViewModels
{
	public class SplashPageViewModel : BasePageViewModel
    {
        protected string MainTabbedPage => "MainTabbedPage";
        Prism.Navigation.INavigationService _navigationService;

        public SplashPageViewModel(Prism.Navigation.INavigationService NavigationService)
        {
            _navigationService = NavigationService;
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);


            await StartUp();
        }

        public async Task StartUp()
        {
            //await NavigationService.NavigateAsync($"/{MainTabbedPage}?createTab=NavigationPage|{"HomePage"}&createTab=NavigationPage|{"ChestPage"}&createTab=NavigationPage|{"ChestPage"}&createTab=NavigationPage|{"MoreMenuItemsPage"}&{KnownNavigationParameters.SelectedTab}={"HomePage"}");
            _navigationService.CreateBuilder().UseAbsoluteNavigation()
                        .AddTabbedSegment(nameof(MainTabbedPage), b =>
                            b
                             .CreateTab(t => t.AddNavigationPage().AddSegment("Tab1Page"))
                             .CreateTab(t => t.AddNavigationPage().AddSegment("Tab2Page"))
                             .CreateTab(t => t.AddNavigationPage().AddSegment("MoreMenuPage"))
                             ).Navigate();
        }
    }
}

