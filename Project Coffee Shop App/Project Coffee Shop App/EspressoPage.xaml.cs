using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Coffee_Shop_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EspressoPage : ContentPage
    {
        public EspressoPage()
        {
            InitializeComponent();
        }

        private async void BackB_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();       
        }
    }
}