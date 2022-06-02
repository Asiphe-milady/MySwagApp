using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySwagApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwagItems : ContentPage
    {
        public SwagItems()
        {
            InitializeComponent();
        }

        private async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new SwagListPage
                {
                    BindingContext = e.SelectedItem as SwagItem
                });
            }
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            SwagItemDatabase database = await SwagItemDatabase.Instance;
            listView.ItemsSource = await database.GetItemsAsync();
        }
        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwagListPage
            {
                BindingContext = new SwagItem()
            });
        }

        private async void Insert(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwagListPage());
        }
    }
}