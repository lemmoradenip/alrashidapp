using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AlRashid
{
    public partial class ShopInfo : ContentPage
    {
        public ShopInfo()
        {
            InitializeComponent();
        }
        public ShopInfo(Shop shop)
        {

            //defensive programming
            if (shop == null)
                throw new ArgumentNullException();

            BindingContext = shop;//this will bind data from class view
                        InitializeComponent();

        }
        void txtSearch_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            //throw new NotImplementedException();

            // lststorelist.ItemsSource = GetShops(e.NewTextValue);
            // await Navigation.PushAsync(new NavigationPage(new MainPage()));
        }

    }
}
