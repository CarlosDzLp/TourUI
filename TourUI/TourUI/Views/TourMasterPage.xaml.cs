using System;
using System.Collections.Generic;
using TourUI.ViewModels;
using Xamarin.Forms;

namespace TourUI.Views
{
    public partial class TourMasterPage : ContentPage
    {
        public TourMasterPage()
        {
            InitializeComponent();
            this.BindingContext = new TourMasterPageViewModel();
        }
    }
}
