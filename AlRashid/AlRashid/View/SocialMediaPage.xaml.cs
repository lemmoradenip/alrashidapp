using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlRashid
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SocialMediaPage : TabbedPage
    {
        public SocialMediaPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            try
            {
                //long method might be from view model repository
                //this will opne in tab style and contains the social media pages

                this.Children.Add(new NavigationPage(new TwitterPage()));
                this.Children[0].Title = "Twitter";
                this.Children.Add(new NavigationPage(new Instagram()));
                this.Children[1].Title = "Insta";
                this.Children.Add(new NavigationPage(new Facebook()));
                this.Children[2].Title = "Facebook";
                this.Children.Add(new NavigationPage(new Youtube()));
                this.Children[3].Title = "Youtube";
               
                
            }
            catch (NullReferenceException ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Close");
            }
        }
    }
}