using Decathlon_App.Models;
using Decathlon_App.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Decathlon_App.ViewModels
{
    internal class Urunler : BindableObject
    {
        private Page Page;

        public Urunler(Page mainPage)
        {
            this.Page = mainPage;
            AddItems();
        }

        private void AddItems()
        {

            UrunItem urunitem = new UrunItem()
            {
                ImageSource = "https://contents.mediadecathlon.com/p1897276/k$2930cc545cc52a420a31468bc0ab5274/sq/8378237.jpg?format=auto&f=320x320",
                UrunIsim = string.Format("QUECHUA"),
                UrunDetay = string.Format("2 kişilik çadır "),
                UrunFiyat = string.Format("1800")
                };
            UrunItem urunitem_1 = new UrunItem()
            {
                ImageSource = "https://contents.mediadecathlon.com/p1749457/k$e411fe28827842702136b98b2dfa322f/sq/katlanir-kamp-masasi-4-6-kisilik.jpg?format=auto&f=720x720",
                UrunIsim = string.Format("QUECHUA"),
                UrunDetay = string.Format("KATLANIR KAMP MASASI - 4/6 KİŞİLİK"),
                UrunFiyat = string.Format("700")
            };
            Items.Add(urunitem);
            UrunItem urunitem_2= new UrunItem()
            {
                ImageSource = "https://contents.mediadecathlon.com/p1985599/k$274329917b907d69480ce23b86fc5ca3/sq/8601390.jpg?format=auto&f=320x320",
                UrunIsim = string.Format("QUECHUA"),
                UrunDetay = string.Format("İKİ KİŞİK HAMAK - 350 X 175"),
                UrunFiyat = string.Format("480")
            };
            UrunItem urunitem_4= new UrunItem()
            {
                ImageSource = "https://contents.mediadecathlon.com/p2203059/k$373f04ace8143ff1e65fd146d6afc34e/sq/8734555.jpg?format=auto&f=320x320",
                UrunIsim = string.Format("QUECHUA"),
                UrunDetay = string.Format("PASLANMAZ ÇELİK DOĞA YÜRÜYÜŞÜ TERMOSU"),
                UrunFiyat = string.Format("170")
            };
            UrunItem urunitem_5 = new UrunItem()
            {
                ImageSource = "https://contents.mediadecathlon.com/p1832204/k$a04403ac0452cc160ae38e1ece853ba1/sq/kamp-golgeligi.jpg?format=auto&f=720x720",
                UrunIsim = string.Format("QUECHUA"),
                UrunDetay = string.Format("KAMP GÖLGELİĞİ"),
                UrunFiyat = string.Format("510")
            };
           
            Items.Add(urunitem_1);
            Items.Add(urunitem_2);
            Items.Add(urunitem_4);
            Items.Add(urunitem_5);


        }
           
        private ObservableCollection<UrunItem> _items = new ObservableCollection<UrunItem>();
        public ObservableCollection<UrunItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    Page.Navigation.PushAsync(new kampcadırı());
                });
            }
        }

        public string ImageSource { get; private set; }
        public string UrunIsim { get; private set; }
        public string UrunFiyat { get; private set; }

       
    }
}
