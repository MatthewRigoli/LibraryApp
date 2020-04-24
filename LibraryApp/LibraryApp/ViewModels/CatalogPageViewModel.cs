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
        }

        /*-----------------Command variables-----------------*/
        private Command individualBookPage;

        public Command IndividualBookPage
        {
            get { return individualBookPage; }
            set { individualBookPage = value; }
        }
        /*-----------------Command variables-----------------*/

        /*--------------------Navagations--------------------*/
        private async void navigate_individualbook_execute()
        {
            await _navigationService.NavigateAsync(nameof(LibraryApp.Views.IndividualBookPage));
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
