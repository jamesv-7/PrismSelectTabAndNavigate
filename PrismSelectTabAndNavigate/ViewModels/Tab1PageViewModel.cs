using System;
using PrismSelectTabAndNavigate.Services;

namespace PrismSelectTabAndNavigate.ViewModels
{
	public class Tab1PageViewModel : BaseViewModel
    {
		public Tab1PageViewModel(INavigationService navigationService) : base(navigationService)
        {
            base.QueryLoaded += Tab1PageViewModel_QueryLoaded;
        }

        private void Tab1PageViewModel_QueryLoaded(object? sender, IDictionary<string, object> e)
        {
            //throw new NotImplementedException();
        }
    }
}

