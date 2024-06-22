using PrismSelectTabAndNavigate.ViewModels;

namespace PrismSelectTabAndNavigate.Pages;

public partial class MoreMenuPage : ContentPage
{
    public MoreMenuViewModel ViewModel { get; private set; }

    public MoreMenuPage(MoreMenuViewModel vm)
    {
        ViewModel = vm;

        this.BindingContext = vm;
        InitializeComponent();
    }
}
