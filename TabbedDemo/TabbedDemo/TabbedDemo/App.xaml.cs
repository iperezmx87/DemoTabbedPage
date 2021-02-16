using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new tbpPrincipal();
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
