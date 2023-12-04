using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Volumen_Gases_JLAP.Vistas;

namespace Volumen_Gases_JLAP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Principal());
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
