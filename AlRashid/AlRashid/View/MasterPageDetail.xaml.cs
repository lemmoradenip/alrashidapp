
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AlRashid.ViewModel;

namespace AlRashid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageDetail : ContentPage
    {

        Shopdata shopdata = new Shopdata();
        public MasterPageDetail()
        {
            InitializeComponent();
            lststorelist.ItemsSource = shopdata.GetFilteredShops();

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            string clickedbtn = String.Empty;
            string searchtext = String.Empty;
            var btn = sender as Button;
            clickedbtn = btn.Text.ToString();

            //#editme this line will be revised soon
            if (clickedbtn == "Shopping")
            { searchtext = "A"; }
            else if (clickedbtn == "Dining")
            { searchtext = "B"; }
            else if (clickedbtn == "Entertainment")
            { searchtext = "C"; }
            else
            { searchtext = ""; }
            lststorelist.ItemsSource = shopdata.GetFilteredShops((searchtext));

        }

        void Handle_Activated(object sender, System.EventArgs e)
        {
            //throw new NotImplementedException();
            DisplayAlert("Hamburger", "Hi sorry for inconviniece humburger is not ready", "Done");
        }

        void lststorelist_Refreshing(object sender, System.EventArgs e)
        {
            lststorelist.ItemsSource = shopdata.GetShops();
            lststorelist.IsRefreshing = false;
        }

        async void lststorelist_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var selectedshop = (Shop)e.SelectedItem;

            await Navigation.PushAsync(new NavigationPage(new ShopInfo(selectedshop)));
         
            lststorelist.SelectedItem = null;
        }


        void txtSearch_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            //throw new NotImplementedException();

            lststorelist.ItemsSource = shopdata.GetShops(e.NewTextValue);
        }

            
    }
}