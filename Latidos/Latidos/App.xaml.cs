using Latidos.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Latidos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VistaLatidos();
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
