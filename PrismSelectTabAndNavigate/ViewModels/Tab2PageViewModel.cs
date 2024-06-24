using System;
using PrismSelectTabAndNavigate.Services;

namespace PrismSelectTabAndNavigate.ViewModels
{
	public class Tab2PageViewModel : BaseViewModel
    {
		public Tab2PageViewModel(INavigationService navigationService) : base(navigationService)
        {
            base.QueryLoaded += Tab2PageViewModel_QueryLoaded;
        }

        private void Tab2PageViewModel_QueryLoaded(object? sender, IDictionary<string, object> e)
        {
            //throw new NotImplementedException();
        }
    }
}

