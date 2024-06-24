using PrismSelectTabAndNavigate.ViewModels;

namespace PrismSelectTabAndNavigate.Pages;

public partial class Tab1Page : ContentPage
{
	private Tab1PageViewModel tab1PageViewModel;

    public Tab1Page(Tab1PageViewModel _tab1PageViewModel)
	{
		InitializeComponent();


        tab1PageViewModel = Helpers.ServiceHelper.GetService<Tab1PageViewModel>();
        this.BindingContext = tab1PageViewModel;
        //this.BindingContext = vm;

    }
}
