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
    public partial class HomePage : ContentPage
    {
        public HomePage()
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

        private void Email_Clicked(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                // Send simple e-mail to single receiver without attachments, bcc, cc etc.
                emailMessenger.SendEmail("lloydmckinnin@gmail.com",
                                    "Xamarin Messaging Plugin",
                                    "Well hello there from Xam.Messaging.Plugin");

                // Alternatively use EmailBuilder fluent interface to construct more complex e-mail with multiple recipients, bcc, attachments etc.
                var email = new EmailMessageBuilder()
                  .To("lloydmckinnin@gmail.com")
                  .Cc("plugins@xamarin.com")
                  .Bcc(new[] { "plugins@xamarin.com", "plugins@xamarin.com" })
                  .Subject("Xamarin Messaging Plugin")
                  .Body("Well hello there from Xam.Messaging.Plugin")
                  .Build();

                emailMessenger.SendEmail(email);
            }
        }
    }
}