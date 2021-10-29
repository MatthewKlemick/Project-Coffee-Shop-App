using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Project_Coffee_Shop_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menupage : TabbedPage
    {
        public Menupage()
        {
            InitializeComponent();
        }
        private async void EspB_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspressoPage());
        }
        private async void HotB_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotDrinksPage());
        }
        private async void ColdB_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColdDrinksPage());
        }
        private async void QuiB_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuickBitesPage());
        }
    }
}