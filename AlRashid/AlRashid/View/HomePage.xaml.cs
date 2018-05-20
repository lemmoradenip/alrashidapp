using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace AlRashid
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        //Code to execute on tapped event
        async void OnImageNameTapped(object sender, EventArgs args)
        {
            try
            {
                //Code to execute on tapped event
                await Navigation.PushModalAsync(new MasterPage());
            }
            catch (Exception ex)
            {
                throw ex;
               
            }
        }

        async void EventTapped(object sender, EventArgs args)
        {
            try
            {
                //Code to execute on tapped event
                await Navigation.PushModalAsync(new MasterPage());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        async void SocialMediaTapped(object sender, EventArgs args)
        {
            try
            {
                //Code to execute on tapped event
                await Navigation.PushModalAsync(new SocialMediaPage());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async void SearchTapped(object sender, EventArgs args)
        {
            try
            {
                //Code to execute on tapped event
                await Navigation.PushModalAsync(new MasterPage());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        async void IconCallTapped(object sender, EventArgs args)
        {
            try
            {
                //Code to execute on tapped event
                await DisplayAlert("Working in Progress", " * Sorry this feature is under developement", "Close");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        async void IconMapsTapped(object sender, EventArgs args)
        {
            try
            {
                //Code to execute on tapped event
                await DisplayAlert("Working in Progress", " * Sorry this feature is under developement", "Close");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        async void IconDirectionsTapped(object sender, EventArgs args)
        {
            try
            {
                //Code to execute on tapped event
                await DisplayAlert("Working in Progress", " * Sorry this feature is under developement", "Close");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        async void IconCalendarTapped(object sender, EventArgs args)
        {
            try
            {
                //Code to execute on tapped event
                await DisplayAlert("Working in Progress", " * Sorry this feature is under developement", "Close");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
