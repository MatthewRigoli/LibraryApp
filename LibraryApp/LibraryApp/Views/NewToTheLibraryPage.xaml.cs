﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LibraryApp.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class NewToTheLibraryPage : ContentPage, INotifyPropertyChanged
    {
        public NewToTheLibraryPage()
        {
            InitializeComponent();
        }
    }
}
