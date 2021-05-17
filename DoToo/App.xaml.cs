using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MedicineTracker.Views;

namespace MedicineTracker
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            MainPage = new NavigationPage(Resolver.Resolve<MainView>());
            // MainPage = new MainPage();
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
