using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LibraryApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyResourceDictionary : ContentPage
    {
        public MyResourceDictionary()
        {
            InitializeComponent();
        }
    }
}