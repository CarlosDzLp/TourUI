using System;
using System.Collections.Generic;
using TourUI.ViewModels;
using Xamarin.Forms;

namespace TourUI.Views
{
    public partial class TourDetailPage : ContentPage
    {
        public TourDetailPage()
        {
            InitializeComponent();
            this.BindingContext = new TourDetailPageViewModel();
        }
    }
}
