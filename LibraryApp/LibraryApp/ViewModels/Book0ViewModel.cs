using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LibraryApp.ViewModels
{
    class Book0ViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public Book0ViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "New Books Page";
            _navigationService = navigationService;
        }

        
        /*--------------------Navagations--------------------*/

        /*--------------------Navagations--------------------*/

        /*----------------------Images-----------------------*/
        //Book Image Headliner
        public ImageSource Books => ImageSource.FromResource("LibraryApp.images.Skyward.jpg");
        /*----------------------Images-----------------------*/

    }
}
