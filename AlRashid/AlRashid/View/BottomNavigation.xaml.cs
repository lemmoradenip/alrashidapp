using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlRashid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomNavigation //: ContentPage
    {
        public BottomNavigation()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            try
            {
                //long method might be from view model repository
                //this will opne in tab style and contains the social media pages
            }
            catch (NullReferenceException ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Close");
            }
        }
    }

}
