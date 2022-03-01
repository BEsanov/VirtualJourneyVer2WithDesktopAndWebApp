using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualJourney.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        public async void PersonalizeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PersonalizationPage());
        }
    }
}