using System;
using PrismSelectTabAndNavigate.Services;

namespace PrismSelectTabAndNavigate.ViewModels
{
    public class BasePageViewModel : BaseViewModel
    {
        public BasePageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public void OnAppearing()
        {
            //throw new NotImplementedException();
        }

        public void OnDisappearing()
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnResume()
        {
            //throw new NotImplementedException();
        }

        public void OnSleep()
        {
            //throw new NotImplementedException();
        }
    }
}

