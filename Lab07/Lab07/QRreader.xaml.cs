using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace Lab07
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRreader : ContentPage
    {
        public QRreader()
        {
            InitializeComponent();
        }

        private void Clicked(object sender, EventArgs e)
        {
            Scan();
        }

        private async void Scan()
        { 

        }


    }
}