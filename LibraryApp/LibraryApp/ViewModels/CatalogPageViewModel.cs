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
        public ImageSource Book1 => ImageSource.FromResource("LibraryApp.images.Skyward.jpg");
        /*----------------------Images-----------------------*/

    }
}
