using System;
namespace PrismSelectTabAndNavigate.ViewModels
{
	public class MoreMenuPageModel : BasePageViewModel
    {

        public MoreMenuPageModel()
        {
        }


        private DelegateCommand _logInCommand;
        public DelegateCommand LogInCommand => _logInCommand ?? (_logInCommand = new DelegateCommand(NavigateToCreateAccountPage));
        private async void NavigateToCreateAccountPage()
        {

            var parameters = new NavigationParameters
            {
                { "NavigateToPage", "CreateAccountPage" }
            };

            //var result = await _navigationService.SelectTabAsync("Tab1Page", parameters);
            await CoreMethods.SwitchSelectedTab<Tab1PageModel>();
            Thread.Sleep(2000);
            await CoreMethods.PushPageModel<CreateAccountPageModel>();
            //await _navigationService.SelectTabAsync("Tab1Page", new Uri("CreateAccountPage", UriKind.Relative));


        }
    }
}

