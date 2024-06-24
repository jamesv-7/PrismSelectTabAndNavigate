using PrismSelectTabAndNavigate.ViewModels;

namespace PrismSelectTabAndNavigate.Pages;

public partial class MoreMenuPage : ContentPage
{
    public MoreMenuPageViewModel ViewModel { get; private set; }

    public MoreMenuPage(MoreMenuPageViewModel vm)
    {
        ViewModel = vm;

        this.BindingContext = vm;
        InitializeComponent();
    }
}
