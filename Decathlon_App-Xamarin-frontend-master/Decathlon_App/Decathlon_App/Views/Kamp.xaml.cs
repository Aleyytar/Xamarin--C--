﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Decathlon_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kamp : ContentPage
    {
        public Kamp()
        {
            InitializeComponent();
        }

        private void Button_Clicked_k(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TKurunler());
        }
    }
}