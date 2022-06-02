using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySwagApp
{
    public partial class App : Application
    {
        public Color BarTextColor { get; }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new SwagItems());
            {
                BarTextColor = Color.Pink;
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
