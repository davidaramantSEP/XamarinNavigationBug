using System;
using System.Diagnostics;
using System.Threading.Tasks;
using NavTest.Models;
using Xamarin.Forms;
using NavTest.Views;

namespace NavTest.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public Command GoDeeperCommand { get; }

        public ItemDetailViewModel()
        {
            GoDeeperCommand = new Command(OnGoDeeper);
        }

        private void OnGoDeeper()
        {
            GoDeeper();
        }

        public async void GoDeeper()
        {
            await Shell.Current.GoToAsync($"{nameof(ThirdLevelPage)}?Param=GoingForward");
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
