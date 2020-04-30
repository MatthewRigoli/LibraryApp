using Prism;
using Prism.Ioc;
using LibraryApp.ViewModels;
using LibraryApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LibraryApp
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<NewToTheLibraryPage, NewToTheLibraryPageViewModle>();
            containerRegistry.RegisterForNavigation<EventsPage, EventsPageViewModel>();
            containerRegistry.RegisterForNavigation<CatalogPage, CatalogPageViewModel>();
            containerRegistry.RegisterForNavigation<Book0, Book0ViewModel>();
            containerRegistry.RegisterForNavigation<Book1Page, Book1PageViewModel>();
        }
    }
}
