
using AlRashid.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AlRashid.ViewModel
{
    public class HorizontalListViewModel : ViewModelBase
    {
        void Initialize()
        {
            this.Items = new ObservableCollection<Item> {
                new Item{Image = "http://www.clubparadiso.it/upload/CONF66/20150909/Green_Island_Resort_Barriera_corallina-tSa-80X80.jpg", Name="Barriera Corallina" },
                new Item{Image = "http://www.clubparadiso.it/upload/CONF66/20150515/Vahine_Island_Resort-tSa-80X80.jpg", Name="Il Paradiso"},
                new Item{Image = "http://4everstatic.com/immagini/80x80/natura/barriera-corallina,-pesci-colorati-148311.jpg", Name="We Are In Puglia"},
                new Item{Image = "http://www.clubparadiso.it/upload/CONF66/20150729/Yasawa_Islands_Resort_e_SPA_giardino-tSa-80X80.jpg", Name="Maldive"},
                new Item{Image = "http://www.amando.it/imagesdyn/gallery_plus/80x80/12/80/la-grande-barriera-corallina-dellaustralia_128073.jpg", Name="La Grande Barriera Corallina"},
                new Item{Image = "http://tartapedia.it/wp-content/themes/arthemia-premium/scripts/timthumb.php?src=/http://tartapedia.it/wp-content/uploads/2013/06/PROTEGGIAMO-LA-BARRIERA-CORALLINA.jpg&w=80&h=80&zc=1&q=100", Name="Proteggiamo la natura"},
                new Item{Image = "http://www.amando.it/imagesdyn/gallery_plus/80x80/12/80/belize-blue-hole_128072.jpg", Name="Azzurro, azzurro"}
            };
        }
        public ObservableCollection<Item> Items
        {
            get { return GetValue<ObservableCollection<Item>>(); }
            set { SetValue(value); }
        }
    }
}
