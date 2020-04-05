using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace LibraryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PhoneCall_Clicked(object sender, EventArgs e)
        {
            var phoneCall = CrossMessaging.Current.PhoneDialer;
            if (phoneCall.CanMakePhoneCall)
            {
                phoneCall.MakePhoneCall("+4354623240", "Mckinnin!");
            }
        }
    }
}