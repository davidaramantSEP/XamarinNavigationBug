using System;
using System.Collections.Generic;
using NavTest.ViewModels;
using NavTest.Views;
using Xamarin.Forms;

namespace NavTest
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ThirdLevelPage), typeof(ThirdLevelPage));
            Routing.RegisterRoute(nameof(FourthLevelPage), typeof(FourthLevelPage));
        }

    }
}
