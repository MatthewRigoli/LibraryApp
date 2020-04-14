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
        }

        /*-----------------Command variables-----------------*/
        private Command homePage;

        public Command HomePage
        {
            get { return homePage; }
            set { homePage = value; }
        }

        /*-----------------Command variables-----------------*/

        /*--------------------Navagations--------------------*/
        private async void navigate_home_execute()
        {
            await _navigationService.NavigateAsync(nameof(LibraryApp.Views.HomePage));
        }
     
        /*--------------------Navagations--------------------*/

        /*----------------------Images-----------------------*/
        public ImageSource Book => ImageSource.FromResource("LibraryApp.images.Skyward.jpg");
        public ImageSource Book2 => ImageSource.FromResource("LibraryApp.images.Skyward.jpg");
        public ImageSource Movie => ImageSource.FromResource("LibraryApp.images.Onward.jpg");
        /*----------------------Images-----------------------*/

        /*---------------------TestCode----------------------*/
        
        /*---------------------TestCode----------------------*/
    }
}
