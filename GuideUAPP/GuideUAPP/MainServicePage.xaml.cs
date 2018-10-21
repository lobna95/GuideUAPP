using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuideUAPP.Database;
using Plugin.Geolocator;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace GuideUAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainServicePage : MasterDetailPage
    {
        Connection conn = new Connection();

        string name;

        public MainServicePage(string username)
        {
            InitializeComponent();

            name = username;

            var Query = conn.db.Table<User>();

            foreach (var data in Query)
            {
                if(username == data.UserName || username == data.Email)
                {
                    userName.Text = data.FirstName + " " + data.LastName;
                }
            }
            
            pp.Source = ImageSource.FromResource("GuideUAPP.Assets.profile.png");
            
            TapGestureRecognizer profileTap = new TapGestureRecognizer();
            TapGestureRecognizer aboutUsTap = new TapGestureRecognizer();
            TapGestureRecognizer logoutTap = new TapGestureRecognizer();
            TapGestureRecognizer settingsTap = new TapGestureRecognizer();
            TapGestureRecognizer paymentTap = new TapGestureRecognizer();
            TapGestureRecognizer tourGuideTap = new TapGestureRecognizer();
            TapGestureRecognizer reservedTap = new TapGestureRecognizer();
            TapGestureRecognizer pinTap = new TapGestureRecognizer();

            TapGestureRecognizer menuTap = new TapGestureRecognizer();


            //pinIcon.Source = ImageSource.FromResource("GuideUAPP.Assets.pin.png");
            //searchbar.Source = ImageSource.FromResource("GuideUAPP.Assets.search.png");
            profileTap.Tapped += ProfileTap_Tapped;
            aboutUsTap.Tapped += AboutUsTap_Tapped;
            logoutTap.Tapped += LogoutTap_Tapped;
            paymentTap.Tapped += PaymentTap_Tapped;
            tourGuideTap.Tapped += TourGuideTap_Tapped;
            settingsTap.Tapped += SettingsTap_Tapped;
            menuTap.Tapped += MenuTap_Tapped;
            reservedTap.Tapped += ReservedTap_Tapped;
            pinTap.Tapped += PinTap_Tapped;

            profileGrid.GestureRecognizers.Add(profileTap);
            aboutUs.GestureRecognizers.Add(aboutUsTap);
            logout.GestureRecognizers.Add(logoutTap);
            settings.GestureRecognizers.Add(settingsTap);
            tourGuide.GestureRecognizers.Add(tourGuideTap);
            reserved.GestureRecognizers.Add(reservedTap);
            payment.GestureRecognizers.Add(paymentTap);
            hamburgerMenu.GestureRecognizers.Add(menuTap);
            //pinIcon.GestureRecognizers.Add(pinTap);
            
            var pin2 = new Pins
            {
                Type = PinType.Place,
                Position = new Position(30.048057, 31.233645),
                Label = "Egyptian Museum Cairo",
                Address = "15 Meret Basha, Ismailia, Qasr an Nile, Cairo Governorate",
                Id = "Xamarin2",
                Url = ""
            };

            Map.CustomPins = new List<Pins> { pin2 };
            Map.Pins.Add(pin2);

            pin2.Clicked += async(sender, e) => {
                await Navigation.PushAsync(new TouristicPlacePage());
            };


            Map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(30.048057, 31.233645), Distance.FromKilometers(1.0)));

        }
        private async void ReservedTap_Tapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new TGReservations());

        }

        private async void PinTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TouristicPlacePage());
        }

        public bool IsLocationAvailable()
        {
            if (!CrossGeolocator.IsSupported)
                return false;

            return CrossGeolocator.Current.IsGeolocationAvailable;
        }

        private void MenuTap_Tapped(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
            (mainPage as MasterDetailPage).IsPresented = true;
        }



        private async void SettingsTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage(name));
        }

        private async void TourGuideTap_Tapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new TGHistory());

        }

        private async void PaymentTap_Tapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new PaymentMethodPage());
        }

        private void LogoutTap_Tapped(object sender, EventArgs e)
        {
            var view = new NavigationPage(new SigninPage());
            Application.Current.MainPage = view;
        }

        private async void AboutUsTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUsPage());
        }

        private async void ProfileTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TouristProfile(name));
        }


    }
}