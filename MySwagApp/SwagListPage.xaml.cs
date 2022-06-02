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
    public partial class SwagListPage : ContentPage
    {
        public SwagListPage()
        {
            InitializeComponent();
            var swag = new SwagItem();
            BindingContext = swag;
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            var swag = (SwagItem)BindingContext;
            SwagItemDatabase database = await SwagItemDatabase.Instance;
            await database.DeleteItemAsync(swag);
            await Navigation.PushAsync(new SwagItems());
        }

        private async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwagItems());
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            var swag = (SwagItem)BindingContext;
            SwagItemDatabase database = await SwagItemDatabase.Instance;
            await database.SaveItemAsync(swag);
            await Navigation.PushAsync(new SwagItems());
        }
    }
}











