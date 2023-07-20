using Decathlon_App.Models;
using Decathlon_App.ViewModels;
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
    public partial class HomePage : ContentPage
    {
        UrunModel UrunModel;
        public HomePage()
        {
            InitializeComponent();
            List<string> CarouselItems = new List<string>()
            {
                "ilkindirim.PNG",
                "indirim2.PNG",
                "indirim3.PNG"
            };
            FırsatlarCarousel.ItemsSource = CarouselItems;
            UrunModel = new UrunModel(this);
            BindingContext = UrunModel;
        }

        internal void DisplayAlert(object p)
        {
            throw new NotImplementedException();
        }
        private async void GotoCamp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TKurunler());
        }
    }
}