using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Decathlon_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bag : ContentPage
    {
        public Bag()
        {
            InitializeComponent();
        }
        private async void GotoHomePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
        private async void GotoAccount(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Account(),false);
        }

        private void Button_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
    }
}