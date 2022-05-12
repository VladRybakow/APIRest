using APIRest.Services;
using APIRest.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIRest
{
    public partial class App : Application
    {
        public static EntryManager CountManager { get; private set; }
        public App()
        {
            CountManager = new EntryManager(new RestService());
            MainPage = new NavigationPage(new EntryListPage());
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
