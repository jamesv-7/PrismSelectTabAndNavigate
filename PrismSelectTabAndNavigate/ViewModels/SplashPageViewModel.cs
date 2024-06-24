using System;
namespace PrismSelectTabAndNavigate.ViewModels
{
	public class SplashPageViewModel : BasePageViewModel
    {
        protected string MainTabbedPage => "MainTabbedPage";

        public SplashPageViewModel()
        {
        }

        public override async void Init(object initData)
        {
            base.Init(initData);

            await StartUp();
        }



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

