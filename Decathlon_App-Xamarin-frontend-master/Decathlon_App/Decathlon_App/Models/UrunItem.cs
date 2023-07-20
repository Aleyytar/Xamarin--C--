using System;
using System.Collections.Generic;
using System.Text;

namespace Decathlon_App.Models
{
    internal class UrunItem
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
        public string UrunFiyat
        {
            get { return urunf; }
            set { urunf = value; }
        }
    }
}
