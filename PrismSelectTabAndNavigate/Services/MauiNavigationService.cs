using System;
namespace PrismSelectTabAndNavigate.Services
{
    public class MauiNavigationService : INavigationService
    {
        public INavigation GetXamNavigation()
        {
            return App.Current.MainPage.Navigation;
        }

        public Task InitializeAsync()
        {
            string token = "token";
            return NavigateToAsync(string.IsNullOrEmpty(token)
                ? "//Login"
                : "//Main");
        }

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            return
                routeParameters != null
                    ? Shell.Current.GoToAsync(route, routeParameters)
                    : Shell.Current.GoToAsync(route);
        }
        //go back one page
        public Task PopAsync()
        {

            return Shell.Current.GoToAsync("..");
        }

        public async Task<bool> ShowDialog(string title, string msg, string accept = "Yes", string cancel = "")
        {
            return await Application.Current.MainPage.DisplayAlert(title, msg, accept, cancel: cancel);


        }

        Task INavigationService.ShowDialog(string title, string msg, string accept, string cancel)
        {
            return Application.Current.MainPage.DisplayAlert(title, msg, accept, cancel: cancel);
        }
    }
}

