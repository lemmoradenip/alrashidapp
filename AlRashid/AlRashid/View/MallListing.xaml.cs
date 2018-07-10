using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace AlRashid
{
    public class MallInfo
    {
        //public int Id { get; set; }
        //public string Title { get; set; }
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MallListing : ContentPage
    {
        private const string Url = "http://192.168.20.55/api/malls";//take the json from this method
        //private const string Url = "http://jsonplaceholder.typicode.com/posts";
        private HttpClient _httpclient = new HttpClient();
      //  private ObservableCollection<MallInfo> _mallinfo;
        public MallListing()
        {
            InitializeComponent();
        }

        protected override  void OnAppearing()  
        {/*
            var content = await _httpclient.GetStringAsync(Url);//
            var mallinfo = JsonConvert.DeserializeObject<List<MallInfo>>(content);//pass the value from URI to var mallinfo via Deserialize
            _mallinfo = new ObservableCollection<MallInfo>(mallinfo);
            lstMallList.ItemsSource = _mallinfo;
            base.OnAppearing();*/
        //    var content = await _httpclient.GetStringAsync(Url);
            lstMallList.ItemsSource = GetMallList();
           
            base.OnAppearing();
        }

        void lstMallList_Refreshing(object sender, System.EventArgs e)
        {
            //lstMallList.ItemsSource = GetMallList();
            lstMallList.IsRefreshing = false;
        }

        async void lstMallList_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {


            //** put here the line for SQLite data **`
            //await Navigation.PushAsync(new NavigationPage(new WelcomePage()));

            //var entity = ((Label)sender);
            //entity.BackgroundColor = Color.AliceBlue;
            await Navigation.PushModalAsync(new NavigationPage(new BottomNavigation()));

        }

        //** this line will be moved to ViewModel with SQL
        private IEnumerable<Malls> GetMallList()
        {
            var shoplist = new List<Malls>
            {
                new Malls{Title="AL RASHID MEGA MALL - MADINAH",IconImageUrl="logodown.png",Description=""}
                , new Malls{Title="AL RASHID MALL - JIZAN",IconImageUrl="logodown.png",Description=""}
                , new Malls{Title="AL RASHID MALL - ABHA",IconImageUrl="logodown.png",Description=""}
            };

            return shoplist;
        }


        //Code to execute on tapped event
        //async void OnImageNameTapped(object sender, EventArgs args)
        //{
        //    try
        //    {
        //        //Code to execute on tapped event
        //        await DisplayAlert("Alert", "", "Ok");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}