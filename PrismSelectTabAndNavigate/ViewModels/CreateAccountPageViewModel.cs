using System;
using PrismSelectTabAndNavigate.Services;

namespace PrismSelectTabAndNavigate.ViewModels
{
	public class CreateAccountPageViewModel : BaseViewModel
	{
		public CreateAccountPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            base.QueryLoaded += CreateAccountPageViewModel_QueryLoaded;
        }

        private void CreateAccountPageViewModel_QueryLoaded(object? sender, IDictionary<string, object> e)
        {
            //throw new NotImplementedException();
        }
    }
}

