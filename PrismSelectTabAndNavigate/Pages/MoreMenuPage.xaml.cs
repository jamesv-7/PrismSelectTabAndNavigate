using PrismSelectTabAndNavigate.ViewModels;

namespace PrismSelectTabAndNavigate.Pages;

public partial class MoreMenuPage : ContentPage
{
    public MoreMenuPageModel ViewModel { get; private set; }

    public MoreMenuPage(MoreMenuPageModel vm)
    {
        ViewModel = vm;

        this.BindingContext = vm;
        InitializeComponent();
    }
}
