﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlRashid
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        async private void BtnEng_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MallListing()));
        }
        async private void BtnAra_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MallListing()));

        }

        async private void Twitter_Tapped(object sender, EventArgs e)
        {
            try
            {
                //Code to execute on tapped event
                await Navigation.PushAsync(new TwitterPage());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        async private void Facebook_Tapped(object sender, EventArgs e)
        {
            try
            {
                //Code to execute on tapped event
                await Navigation.PushAsync(new Facebook());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        async private void Instagram_Tapped(object sender, EventArgs e)
        {
            try
            {
                //Code to execute on tapped event
                await Navigation.PushAsync(new Instagram());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        async private void Youtube_Tapped(object sender, EventArgs e)
        {
            try
            {
                //Code to execute on tapped event
                await Navigation.PushAsync(new Youtube());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}