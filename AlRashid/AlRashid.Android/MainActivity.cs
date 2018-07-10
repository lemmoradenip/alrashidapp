using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace AlRashid.Droid
{
    [Activity(Label = "AlRashid", Icon = "@drawable/icon", Theme = "@style/Splashscreen", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
 
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
       // private BottomBar _bottomBar;
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            
            Xamarin.FormsMaps.Init(this, bundle);//this will initialize the xamarin forms maps.

            base.OnCreate(bundle);

            string filename = "mall_db.sqlite";
            string filelocation = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string fullpath = Path.Combine(filelocation, filename);


            global::Xamarin.Forms.Forms.Init(this, bundle);         
            LoadApplication(new App(fullpath));

       }

       
    }
}

