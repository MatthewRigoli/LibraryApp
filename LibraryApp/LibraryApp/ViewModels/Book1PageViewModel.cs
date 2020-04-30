using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LibraryApp.ViewModels
{
    class Book1PageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public Book1PageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "New Books Page";
            _navigationService = navigationService;
        }


        /*--------------------Navagations--------------------*/

        /*--------------------Navagations--------------------*/

        /*----------------------Images-----------------------*/
        //Book Image Headliner
        public ImageSource Book1 => ImageSource.FromResource("LibraryApp.images.carbook1.jpg");
        /*----------------------Images-----------------------*/


    }
}
