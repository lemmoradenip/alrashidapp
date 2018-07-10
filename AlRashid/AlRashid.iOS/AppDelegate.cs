using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Foundation;
using UIKit;

namespace AlRashid.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            string filename = "mall_db.sqlite";
            // ".." means to get to the parent folder of personal folder 
          //  string filelocation = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal,"..","Library");
            string filelocation = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string fullpath = Path.Combine(filelocation, filename);

            Xamarin.FormsMaps.Init();//this will initialize the forms maps
            global::Xamarin.Forms.Forms.Init();


            LoadApplication(new App(fullpath));

            return base.FinishedLaunching(app, options);
        }
    }
}
