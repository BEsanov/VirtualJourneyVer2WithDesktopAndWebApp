using System.ComponentModel;
using VirtualJourney.ViewModels;
using Xamarin.Forms;

namespace VirtualJourney.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}