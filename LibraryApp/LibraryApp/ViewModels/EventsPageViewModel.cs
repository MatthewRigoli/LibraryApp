using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LibraryApp.ViewModels
{
    class EventsPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public EventsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Mount Pleasant Library Events";
            _navigationService = navigationService; HomePage = new Command(navigate_home_execute);
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
        public ImageSource Logo => ImageSource.FromResource("LibraryApp.images.logo.png");
        /*----------------------Images-----------------------*/

    }
}
