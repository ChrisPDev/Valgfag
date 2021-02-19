using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        readonly ObservableCollection<GalleryBindings> gallery = new ObservableCollection<GalleryBindings>();
        public ObservableCollection<GalleryBindings> Gallery { get { return gallery; } }

        public GalleriSide()
        {
            InitializeComponent();

            GalleryView.ItemsSource = gallery;

            gallery.Add(new GalleryBindings { Image = "Christoffer.jpg", Title = "Profil billede", Description = "Dette er mit profil billede, er jeg ikke flot." });
            gallery.Add(new GalleryBindings { Image = "RedRingHood.jpeg", Title = "Standard baggrunden", Description = "Bruger dette billede som baggrund på alt jeg kan sætte det på." });
            gallery.Add(new GalleryBindings { Image = "Christoffer.jpg", Title = "Profil billede", Description = "Dette er mit profil billede, er jeg ikke flot." });
            gallery.Add(new GalleryBindings { Image = "RedRingHood.jpeg", Title = "Standard baggrunden", Description = "Bruger dette billede som baggrund på alt jeg kan sætte det på." });
            gallery.Add(new GalleryBindings { Image = "Christoffer.jpg", Title = "Profil billede", Description = "Dette er mit profil billede, er jeg ikke flot." });
            gallery.Add(new GalleryBindings { Image = "RedRingHood.jpeg", Title = "Standard baggrunden", Description = "Bruger dette billede som baggrund på alt jeg kan sætte det på." });
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

        private void GetImgFromDeviceBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}