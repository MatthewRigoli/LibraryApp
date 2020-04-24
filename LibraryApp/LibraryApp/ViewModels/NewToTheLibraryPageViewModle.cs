using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace LibraryApp.ViewModels
{
    class NewToTheLibraryPageViewModle : ViewModelBase
    {
        private INavigationService _navigationService;
        public NewToTheLibraryPageViewModle(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "New Books Page";
            _navigationService = navigationService;
            HomePage = new Command(navigate_home_execute);
            CatalogPage = new Command(navigate_catalog_execute);
        }

        /*-----------------Command variables-----------------*/
        private Command homePage;

        public Command HomePage
        {
            get { return homePage; }
            set { homePage = value; }
        }

        private Command catalogPage;

        public Command CatalogPage
        {
            get { return catalogPage; }
            set { catalogPage = value; }
        }

        /*-----------------Command variables-----------------*/

        /*--------------------Navagations--------------------*/
        private async void navigate_home_execute()
        {
            await _navigationService.NavigateAsync(nameof(LibraryApp.Views.HomePage));
        }

        private async void navigate_catalog_execute()
        {
            await _navigationService.NavigateAsync(nameof(LibraryApp.Views.CatalogPage));
        }

        /*--------------------Navagations--------------------*/

        /*----------------------Images-----------------------*/
        //Book Image Headliner
        public ImageSource Book => ImageSource.FromResource("LibraryApp.images.Skyward.jpg");

        //Carousel Book Images
        public ImageSource Book1 => ImageSource.FromResource("LibraryApp.images.carbook1.jpg");
        public ImageSource Book2 => ImageSource.FromResource("LibraryApp.images.carbook2.jpg");
        public ImageSource Book3 => ImageSource.FromResource("LibraryApp.images.carbook3.jpg");
        public ImageSource Book4 => ImageSource.FromResource("LibraryApp.images.carbook4.jpg");
        public ImageSource Book5 => ImageSource.FromResource("LibraryApp.images.carbook5.jpg");
        public ImageSource Book6 => ImageSource.FromResource("LibraryApp.images.carbook6.jpg");
        public ImageSource Book7 => ImageSource.FromResource("LibraryApp.images.carbook7.jpg");
        public ImageSource Book8 => ImageSource.FromResource("LibraryApp.images.carbook8.jpg");

        //Movie Image Headliner
        public ImageSource Movie => ImageSource.FromResource("LibraryApp.images.Onward.jpg");

        //Carousel Movie Images
        public ImageSource Movie1 => ImageSource.FromResource("LibraryApp.images.carmovie1.jpg");
        public ImageSource Movie2 => ImageSource.FromResource("LibraryApp.images.carmovie2.jpg");
        public ImageSource Movie3 => ImageSource.FromResource("LibraryApp.images.carmovie3.jpg");
        public ImageSource Movie4 => ImageSource.FromResource("LibraryApp.images.carmovie4.jpg");
        public ImageSource Movie5 => ImageSource.FromResource("LibraryApp.images.carmovie5.jpg");
        public ImageSource Movie6 => ImageSource.FromResource("LibraryApp.images.carmovie6.jpg");
        public ImageSource Movie7 => ImageSource.FromResource("LibraryApp.images.carmovie7.jpg");
        public ImageSource Movie8 => ImageSource.FromResource("LibraryApp.images.carmovie8.jpg");


        /*----------------------Images-----------------------*/
    }
}
