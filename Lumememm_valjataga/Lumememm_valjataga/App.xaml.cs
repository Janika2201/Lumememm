using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm_valjataga
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Absolute();
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
