using System;
using PrismSelectTabAndNavigate.Pages;
using PrismSelectTabAndNavigate.Services;

namespace PrismSelectTabAndNavigate.ViewModels
{
	public class MoreMenuPageViewModel : BaseViewModel
    {

        public MoreMenuPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            base.QueryLoaded += MoreMenuPageViewModel_QueryLoaded;
        }

        private void MoreMenuPageViewModel_QueryLoaded(object? sender, IDictionary<string, object> e)
        {
         //   throw new NotImplementedException();
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

            //await _navigationService.SelectTabAsync("Tab1Page", new Uri("CreateAccountPage", UriKind.Relative));

            await Shell.Current.GoToAsync($"//{nameof(Tab1Page)}", animate: true, (IDictionary<string, object>)new Dictionary<string, object> { { "QueryDict", "Goto Tab 1" } });

            await Shell.Current.GoToAsync(nameof(CreateAccountPage), animate: true, (IDictionary<string, object>)new Dictionary<string, object> { { "QueryDict", "Goto Tab 1" } });


        }
    }
}

