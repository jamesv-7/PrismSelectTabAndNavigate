using System;
using CommunityToolkit.Mvvm.ComponentModel;
using PrismSelectTabAndNavigate.Services;

namespace PrismSelectTabAndNavigate.ViewModels
{

    public partial class BaseViewModel : ObservableObject, IQueryAttributable, IDisposable
    {
        //activity variables

        [ObservableProperty]
        private string activityImage;

        [ObservableProperty]
        private bool dateMode;
        [ObservableProperty]
        private bool hasHeader;

        [ObservableProperty]
        private bool hasFooter;

        //[ObservableProperty]
        private bool hasCarousel;

        [ObservableProperty]
        private string newActivityTime = string.Format("Today, {0}", DateTime.Now.ToShortTimeString());

        [ObservableProperty]
        private bool activityDateChanged = false;

        //[ObservableProperty]
        //private bool footerStackVisible = false;
        // end activity variables

        [ObservableProperty]
        CommunityToolkit.Maui.Behaviors.StatusBarBehavior statusBarBehavior;
        [ObservableProperty]
        private Button closeButton;


        [ObservableProperty]
        private IDictionary<string, object> navigationParameters;

        [ObservableProperty]
        private IDictionary<string, object> queryDictionary;
        [ObservableProperty]
        private int parameterCount = 0;
        [ObservableProperty]
        private IDictionary<string, object> vModelDictionary;



        private bool busy = false;
        private bool disposed;

        public bool HasCarousel
        {
            get => hasCarousel; set
            {
                hasCarousel = value;
                HasHeader = !hasCarousel;
                HasFooter = !hasCarousel;
                DateMode = !HasHeader;

                OnPropertyChanged("HasCarousel");
            }
        }
        
        [ObservableProperty]
        public IConnectivity _connectivity;
        [ObservableProperty]
        public INavigationService _navigationService;


        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            if (this.QueryDictionary == null)
            {
                //Busy = false;
            }

        }


        public event EventHandler<bool> ButtonPressed;

        //  OnButtonPressed(true);
        protected virtual void OnButtonPressed(bool IsPressed)
        {
            ButtonPressed?.Invoke(this, IsPressed);
        }


        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query?.Count() > 0)
            {
                QueryDictionary = query;
                OnQueryLoaded(QueryDictionary);
            }

        }

        public event EventHandler<IDictionary<string, object>> QueryLoaded;
        protected virtual void OnQueryLoaded(IDictionary<string, object> dictionary)
        {
            QueryLoaded?.Invoke(this, dictionary);


        }


        


        public async Task SpeakNow(string text)
        {
            var locales = await TextToSpeech.GetLocalesAsync();

            // Grab the first locale
            var locale = locales.FirstOrDefault();

            var settings = new SpeechOptions()
            {
                Volume = .95f,
                Pitch = 1.0f,
                //Locale = locale
            };

            await TextToSpeech.SpeakAsync(text, settings);
        }



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources (if any)
                }

                // Dispose unmanaged resources (if any)

                disposed = true;
            }
        }


        //public void Receive(MyMessage message)
        //{
        //    OnButtonPressed(true);
        //    //WeakReferenceMessenger.Default.Unregister<MyMessage>(this);
        //    //Shell.Current.DisplayAlert("Message received", message.Value.ToString(), "OK");
        //}
    }
}

