using System;
namespace PrismSelectTabAndNavigate.Services
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null);

        Task PopAsync();

        Task ShowDialog(string title, string msg, string accept = "Yes", string cancel = "Cancel");

        INavigation GetXamNavigation();

    }
}

