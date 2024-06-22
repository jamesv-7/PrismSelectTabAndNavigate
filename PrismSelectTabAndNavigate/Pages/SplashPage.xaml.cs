using PrismSelectTabAndNavigate.ViewModels;

namespace PrismSelectTabAndNavigate.Pages;

public partial class SplashPage : ContentPage
{
    public SplashPageViewModel ViewModel { get; private set; }

    public SplashPage(SplashPageViewModel splashPageViewModel)
    {
        InitializeComponent();

        ViewModel = splashPageViewModel;
        this.BindingContext = ViewModel;
    }

}
