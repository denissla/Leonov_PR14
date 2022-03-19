using Leonov_PR14.Services;
using Leonov_PR14.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Leonov_PR14
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
