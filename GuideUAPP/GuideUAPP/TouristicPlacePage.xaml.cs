using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using System.Reflection;
using System.IO;
using System.Collections.Generic;

namespace GuideUAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TouristicPlacePage : ContentPage
    {

        public TouristicPlacePage()
        {
            InitializeComponent();
            
            musem.Source = ImageSource.FromResource("GuideUAPP.Assets.musem.png");
            

            TapGestureRecognizer videoTap = new TapGestureRecognizer();

            TapGestureRecognizer audioTap = new TapGestureRecognizer();

            TapGestureRecognizer backTap = new TapGestureRecognizer();

            TapGestureRecognizer reserveTap = new TapGestureRecognizer();

            TapGestureRecognizer gotoTap = new TapGestureRecognizer();

            this.IsBusy = false;
            
            gotoTap.Tapped += gotoTap_Tapped;

            videoTap.Tapped += VideoTap_Tapped;

            audioTap.Tapped += audioTap_Tapped;

            reserveTap.Tapped += ReserveTap_Tapped;
          
            backTap.Tapped += BackTap_Tapped;

            goTo.GestureRecognizers.Add(gotoTap);

            video.GestureRecognizers.Add(videoTap);

            audio.GestureRecognizers.Add(audioTap);

            reserve.GestureRecognizers.Add(reserveTap);
        
            back.GestureRecognizers.Add(backTap);
            
        }

        private async void gotoTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new gotoMap());
        }

        private void BackTap_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void ClosePopoUpTap_Tapped(object sender, EventArgs e)
        {
            if (videoPopup.IsVisible == true)
            {
                videoMedia.Stop();
                videoPopup.IsVisible = false;
            }


        }

        private void closeReservationTap_Tapped(object sender, EventArgs e)
        {
            if (reservationPopup.IsVisible == true)
            {
                reservationPopup.IsVisible = false;
            }


        }

        private void CloseaudioTap_Tapped(object sender, EventArgs e)
        {
            if (audioPopup.IsVisible == true)
            {
                audioPlayer(false);
                audioPopup.IsVisible = false;
            }


        }

        private void audioPlayer(bool flag)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream("GuideUAPP.Assets." + "musemaudio.mp3");


            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(audioStream);
            if (flag)
                player.Play();
            else
                player.Stop();
        }

        private void audioTap_Tapped(object sender, EventArgs e)
        {
            if (videoPopup.IsVisible == false)
            {
                audioPlayer(true);
                audioPopup.IsVisible = true;
            }
        }

        private void VideoTap_Tapped(object sender, EventArgs e)
        {
            if (videoPopup.IsVisible == false)
            {
                videoMedia.Play();
                videoPopup.IsVisible = true;
            }
        }

        private void ReserveTap_Tapped(object sender, EventArgs e)
        {
            if (reservationPopup.IsVisible == false)
            {
                reservationPopup.IsVisible = true;
            }
        }

        private async void Reserver_Clicked(object sender, EventArgs e)
        {
            if (reservationPopup.IsVisible == true)
                await DisplayAlert("Message", "A tour guide has been reserved for you", "OK");
        }
    }
}