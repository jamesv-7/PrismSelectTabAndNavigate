using PrismSelectTabAndNavigate.ViewModels;

namespace PrismSelectTabAndNavigate.Pages;

public partial class SplashPage : ContentPage
{
    public SplashPageModel ViewModel { get; private set; }

    public SplashPage(SplashPageModel splashPageViewModel)
    {
        InitializeComponent();

        ViewModel = splashPageViewModel;
        this.BindingContext = ViewModel;
    }

}
