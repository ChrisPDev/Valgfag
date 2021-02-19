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
    public partial class CvSide : ContentPage
    {
        public CvSide()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("UddannelseText")) UddannelseText.Text = Application.Current.Properties["UddannelseText"].ToString();
            if (Application.Current.Properties.ContainsKey("TidligereJobsText")) TidligereJobsText.Text = Application.Current.Properties["TidligereJobsText"].ToString();
            if (Application.Current.Properties.ContainsKey("StyrkerText")) StyrkerText.Text = Application.Current.Properties["StyrkerText"].ToString();
            if (Application.Current.Properties.ContainsKey("InteresserText")) InteresserText.Text = Application.Current.Properties["InteresserText"].ToString();
            if (Application.Current.Properties.ContainsKey("GenereltText")) GenereltText.Text = Application.Current.Properties["GenereltText"].ToString();
        }
        private void OnChange(object sender, EventArgs e)
        {
            Application.Current.Properties["UddannelseText"] = UddannelseText.Text;
            Application.Current.Properties["TidligereJobsText"] = TidligereJobsText.Text;
            Application.Current.Properties["StyrkerText"] = StyrkerText.Text;
            Application.Current.Properties["InteresserText"] = InteresserText.Text;
            Application.Current.Properties["GenereltText"] = GenereltText.Text;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
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