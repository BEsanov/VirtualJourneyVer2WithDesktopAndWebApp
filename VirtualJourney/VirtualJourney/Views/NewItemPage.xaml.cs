using System;
using System.Collections.Generic;
using System.ComponentModel;
using VirtualJourney.Models;
using VirtualJourney.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualJourney.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}