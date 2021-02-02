using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavTest.Views
{
    public partial class FourthLevelPage : ContentPage
    {
        public FourthLevelPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("..?Param=GoingBack");
        }
    }
}
