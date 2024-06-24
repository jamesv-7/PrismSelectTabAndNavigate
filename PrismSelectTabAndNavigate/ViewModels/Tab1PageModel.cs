using System;
namespace PrismSelectTabAndNavigate.ViewModels
{
	public class Tab1PageModel : BasePageViewModel
    {
		public Tab1PageModel()
		{
		}

        public override void Init(object initData)
        {
            base.Init(initData);

            if (initData != null)
            {
                INavigationParameters parameters = initData as INavigationParameters;

                if (parameters.ContainsKey("NavigateToPage"))
                    CoreMethods.PushPageModel<CreateAccountPageModel>();
            }
        }
    }
}

