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
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
        public ImageSource Logo => ImageSource.FromResource("LibraryApp.images.logo.png");
        public ImageSource Book => ImageSource.FromResource("LibraryApp.images.Skyward.jpg");
        public ImageSource Book2 => ImageSource.FromResource("LibraryApp.images.kill.jpg");
    }
}
