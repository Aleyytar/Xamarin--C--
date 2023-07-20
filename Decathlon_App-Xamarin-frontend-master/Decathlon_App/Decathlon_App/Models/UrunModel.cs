using Decathlon_App.Models;
using Decathlon_App.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Decathlon_App.ViewModels
{
    internal class UrunModel
    {
        private string image;
        public string ImageSource
        {
            get { return image; }
            set { image = value; }
        }
        private string uruni;
        public string UrunIsim
        {
            get { return uruni; }
            set { uruni = value; }
        }
        private string urund;
        public string UrunDetay
        {
            get { return urund; }
            set { urund = value; }

        }
        private string urunf;
        private HomePage homePage;

        public UrunModel(HomePage homePage)
        {
            this.homePage = homePage;
        }

        public UrunModel()
        {
        }

        public string UrunFiyat
        {
            get { return urunf; }
            set { urunf = value; }
        }
    }
}
