using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideUAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TGReservations : ContentPage
    {
        public ObservableCollection<TripViewModel> TourGuides { get; set; }
        public TGReservations()
        {
            InitializeComponent();
            TourGuides = new ObservableCollection<TripViewModel>();
            TourGuides.Add(new TripViewModel
            {
                ID = 0,
                TGName = "Ahmed Samy",
                TGPP = "Assets/tgmaleeepng.png",
                Nationality = "Egyptian",
                Place = "Egyptian Museum",
                DT = new DateTime(2018, 09, 20)
            });
            listView.ItemsSource = TourGuides;
        }
        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            TGTripDetailsPopUp.IsVisible = true;
            int index = ((TripViewModel)e.SelectedItem).ID;
            TGName.Text = TourGuides[index].TGName;
            PlaceName.Text = TourGuides[index].Place;
            TourDate.Text = Convert.ToString(TourGuides[index].DT);
            TGImage.Source = TourGuides[index].TGPP;


        }
        private void ClosePopoUpTap_Tapped(object sender, EventArgs e)
        {
            if (TGTripDetailsPopUp.IsVisible == true)
                TGTripDetailsPopUp.IsVisible = false;
        }
    }
}