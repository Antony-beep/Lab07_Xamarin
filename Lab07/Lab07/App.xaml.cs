using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab07
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage =  new NavigationPage(new TextToSpeechDemo());
            MainPage = new NavigationPage(new BatteryDemo());
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
