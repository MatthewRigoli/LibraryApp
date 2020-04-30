using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LibraryApp.ViewModels
{
    class CatalogPageViewModel : ViewModelBase
    {

        private INavigationService _navigationService;
        public CatalogPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Mount Pleasant Library";
            _navigationService = navigationService;
            IndividualBookPage = new Command(navigate_individualbook_execute);
            Book0Page = new Command(navigate_book0page_execute);
            Book1Page = new Command(navigate_book1page_execute);
        }

        /*-----------------Command variables-----------------*/
        private Command individualBookPage;

        public Command IndividualBookPage
        {
            get { return individualBookPage; }
            set { individualBookPage = value; }
        }

        private Command book0Page;

        public Command Book0Page
        {
            get { return book0Page; }
            set { book0Page = value; }
        }

        private Command book1Page;

        public Command Book1Page
        {
            get { return book1Page; }
            set { book1Page = value; }
        }
        /*-----------------Command variables-----------------*/

        /*--------------------Navagations--------------------*/
        private async void navigate_individualbook_execute()
        {
            await _navigationService.NavigateAsync(nameof(LibraryApp.Views.IndividualBookPage));
        }

        private async void navigate_book0page_execute()
        {
            await _navigationService.NavigateAsync(nameof(LibraryApp.Views.Book0));
        }

        private async void navigate_book1page_execute()
        {
            await _navigationService.NavigateAsync(nameof(LibraryApp.Views.Book1Page));
        }
        /*--------------------Navagations--------------------*/

        /*----------------------Images-----------------------*/
        public ImageSource Book0 => ImageSource.FromResource("LibraryApp.images.Skyward.jpg");
        public ImageSource Book1 => ImageSource.FromResource("LibraryApp.images.carbook1.jpg");
        public ImageSource Book2 => ImageSource.FromResource("LibraryApp.images.carbook2.jpg");
        public ImageSource Book3 => ImageSource.FromResource("LibraryApp.images.carbook3.jpg");
        public ImageSource Book4 => ImageSource.FromResource("LibraryApp.images.carbook4.jpg");
        public ImageSource Book5 => ImageSource.FromResource("LibraryApp.images.carbook5.jpg");
        public ImageSource Book6 => ImageSource.FromResource("LibraryApp.images.carbook6.jpg");
        public ImageSource Book7 => ImageSource.FromResource("LibraryApp.images.carbook7.jpg");
        public ImageSource Book8 => ImageSource.FromResource("LibraryApp.images.carbook8.jpg");

        /*----------------------Images-----------------------*/

    }
}
