using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualJourney.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalizationPage : ContentPage
    {
        public PersonalizationPage()
        {
            InitializeComponent();
        }
        public async void OnImageNameTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        async void OnCorrectDrop(object sender, DropEventArgs e)
        {
            await DisplayAlert("Done", "Added to your favorites!", "OK");
        }

        void OnIncorrectDragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.None;
        }

        private void ShowButton_Clicked(object sender, EventArgs e)
        {
            RotateSettingicon();
            //showButton.RotateTo(360, 1000);
            //showButton.Rotation = 0;
            selectableGrid.IsVisible = true;
            hideButton.IsVisible = true;
        }
        private void HideButton_Clicked(object sender, EventArgs e)
        {
            hideButton.IsVisible = false;
            selectableGrid.IsVisible = false;
        }
        //This method is unknown for now
        //void OnDragOver(object sender, DragEventArgs e)
        //{
        //    e.AcceptedOperation = DataPackageOperation.None;
        //}
        private async void RotateSettingicon()
        {
            await showButton.RotateTo(360, 500);
            showButton.Rotation = 0;
        }

        //private async void sisuLogo_Clicked(object sender, EventArgs e)
        //{
        //    await sisuLogo.Navigation.PushAsync(new Pages.SisuPage());
        //}
    }
}