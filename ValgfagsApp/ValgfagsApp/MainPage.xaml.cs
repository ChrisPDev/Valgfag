using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ValgfagsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("ProfileName")) ProfileName.Text = Application.Current.Properties["ProfileName"].ToString();
            if (Application.Current.Properties.ContainsKey("ProfileText")) ProfileText.Text = Application.Current.Properties["ProfileText"].ToString();
            if (Application.Current.Properties.ContainsKey("ProfileFullName")) ProfileFullName.Text = Application.Current.Properties["ProfileFullName"].ToString();
            if (Application.Current.Properties.ContainsKey("ProfilePhone")) ProfilePhone.Text = Application.Current.Properties["ProfilePhone"].ToString();
            if (Application.Current.Properties.ContainsKey("ProfileMail")) ProfileMail.Text = Application.Current.Properties["ProfileMail"].ToString();
            if (Application.Current.Properties.ContainsKey("ProfileAddress")) ProfileAddress.Text = Application.Current.Properties["ProfileAddress"].ToString();
            if (Application.Current.Properties.ContainsKey("ProfileCity")) ProfileCity.Text = Application.Current.Properties["ProfileCity"].ToString();
            if (Application.Current.Properties.ContainsKey("ProfileZip")) ProfileZip.Text = Application.Current.Properties["ProfileZip"].ToString();
        }
        private void OnChange(object sender, EventArgs e)
        {
            Application.Current.Properties["ProfileName"] = ProfileName.Text;
            Application.Current.Properties["ProfileText"] = ProfileText.Text;
            Application.Current.Properties["ProfileFullName"] = ProfileFullName.Text;
            Application.Current.Properties["ProfilePhone"] = ProfilePhone.Text;
            Application.Current.Properties["ProfileMail"] = ProfileMail.Text;
            Application.Current.Properties["ProfileAddress"] = ProfileAddress.Text;
            Application.Current.Properties["ProfileCity"] = ProfileCity.Text;
            Application.Current.Properties["ProfileZip"] = ProfileZip.Text;
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
