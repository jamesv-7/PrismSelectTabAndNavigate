using System;
namespace PrismSelectTabAndNavigate.ViewModels
{
	public class MoreMenuViewModel
    {
        Prism.Navigation.INavigationService _navigationService;

        public MoreMenuViewModel(Prism.Navigation.INavigationService NavigationService)
        {
            _navigationService = NavigationService;
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

            await _navigationService.SelectTabAsync("Tab1Page", new Uri("CreateAccountPage", UriKind.Relative));


        }
    }
}

