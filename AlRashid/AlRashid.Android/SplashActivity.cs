//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Xamarin.Forms;
//using Android.Util;
//using Android.Support.V7.App;
//using System.Threading.Tasks;

using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;

namespace AlRashid.Droid
{
    [Activity(Label = "Mobile App Name", Icon = "@drawable/RMM_C", Theme = "@style/Splashscreen", MainLauncher = true, NoHistory = true)]

    public class SplashActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        //protected override void OnResume()
        //{
        //    base.OnResume();
        //    StartActivity(typeof(MainActivity));
        //}

        static readonly string TAG = "X:" + typeof(SplashActivity).Name;
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
            Log.Debug(TAG, "SplashActivity.OnCreate");
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulatedStartup(); });
            startupWork.Start(); 
        }
        public override void OnBackPressed()// prevent the back button from canceling the startup process 
        {
            //base.OnBackPressed();           
        }
        async void SimulatedStartup()
        {
            Log.Debug(TAG, "Performing some startup work that takes a bit of time");
            await Task.Delay(1000);
            Log.Debug(TAG, "Startup work is finished - starting MainActivity.");
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));

        }
    }
}