using System;
using PrismSelectTabAndNavigate.Services;

namespace PrismSelectTabAndNavigate.ViewModels
{
	public class SplashPageViewModel : BaseViewModel
    {
        protected string MainTabbedPage => "MainTabbedPage";

        public SplashPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            base.QueryLoaded += SplashPageViewModel_QueryLoaded;
        }

        private void SplashPageViewModel_QueryLoaded(object? sender, IDictionary<string, object> e)
        {
            //await StartUp();
            //throw new NotImplementedException();
        }

        //public override async void OnNavigatedTo(INavigationParameters parameters)
        //{
        //    base.OnNavigatedTo(parameters);


        //    await StartUp();
        //}

        public async Task StartUp()
        {
            //await NavigationService.NavigateAsync($"/{MainTabbedPage}?createTab=NavigationPage|{"HomePage"}&createTab=NavigationPage|{"ChestPage"}&createTab=NavigationPage|{"ChestPage"}&createTab=NavigationPage|{"MoreMenuItemsPage"}&{KnownNavigationParameters.SelectedTab}={"HomePage"}");
            //_navigationService.CreateBuilder().UseAbsoluteNavigation()
            //            .AddTabbedSegment(nameof(MainTabbedPage), b =>
            //                b
            //                 .CreateTab(t => t.AddNavigationPage().AddSegment("Tab1Page"))
            //                 .CreateTab(t => t.AddNavigationPage().AddSegment("Tab2Page"))
            //                 .CreateTab(t => t.AddNavigationPage().AddSegment("MoreMenuPage"))
            //                 ).Navigate();
        }
    }
}

