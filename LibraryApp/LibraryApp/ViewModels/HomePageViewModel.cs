using LibraryApp.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace LibraryApp.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public HomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Mount Pleasant Library";
            _navigationService = navigationService;
            Books = new Command(navigate_books_execute);
            Events = new Command(navigate_events_execute);
        }

        /*-----------------Command variables-----------------*/
        private Command books;

        public Command Books
        {
            get { return books; }
            set { books = value; }
        }

        private Command events;

        public Command Events
        {
            get { return events; }
            set { events = value; }
        }
        /*-----------------Command variables-----------------*/


        /*--------------------Navagations--------------------*/
        private async void navigate_books_execute()
        {
            await _navigationService.NavigateAsync(nameof(LibraryApp.Views.NewToTheLibraryPage));
        }

        private async void navigate_events_execute()
        {
            await _navigationService.NavigateAsync(nameof(LibraryApp.Views.EventsPage));
        }
        /*--------------------Navagations--------------------*/


        /*----------------------Images-----------------------*/
        public ImageSource Logo => ImageSource.FromResource("LibraryApp.images.logo.png");
        public ImageSource Book => ImageSource.FromResource("LibraryApp.images.Skyward.jpg");
        public ImageSource Book2 => ImageSource.FromResource("LibraryApp.images.kill.jpg");
        public ImageSource EventImage => ImageSource.FromResource("LibraryApp.images.MainPageEvent.jpg");
        /*----------------------Images-----------------------*/
    }
}
