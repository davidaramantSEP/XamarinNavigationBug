using System.ComponentModel;
using Xamarin.Forms;
using NavTest.ViewModels;

namespace NavTest.Views
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