using Decathlon_App.ViewModels;
using DLToolkit.Forms.Controls;
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
    public partial class TKurunler : ContentPage
    {
        Urunler Urunler;
        public TKurunler()
        {

            InitializeComponent();
            
           Urunler = new Urunler(this);
            BindingContext = Urunler;
        }
    }
}