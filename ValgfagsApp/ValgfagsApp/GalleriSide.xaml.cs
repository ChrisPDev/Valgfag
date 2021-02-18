using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ValgfagsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleriSide : ContentPage
    {
        public GalleriSide()
        {
            InitializeComponent();
        }
        private async void ProfilNav_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void CVNav_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CvSide());
        }

        private async void GalleriNav_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GalleriSide());
        }
    }
}