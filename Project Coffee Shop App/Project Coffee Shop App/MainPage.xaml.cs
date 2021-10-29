using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project_Coffee_Shop_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void EspB_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspressoPage());
        }
        private async void HotB_Clicked(object sender, EventArgs e)
        {

        }
        private async void ColdB_Clicked(object sender, EventArgs e)
        {

        }
        private async void QuiB_Clicked(object sender, EventArgs e)
        {

        }
    }
}
