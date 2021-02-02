using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavTest.Views
{
    [QueryProperty("Param", "Param")]
    public partial class ThirdLevelPage : ContentPage
    {
        private string _param;

        public string Param
        {
            get => _param;
            set
            {
                _param = value;
                OnPropertyChanged(nameof(Param));
            }
        }

        public ThirdLevelPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        async void GoDeeper_Clicked(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(FourthLevelPage));
        }
    }
}
