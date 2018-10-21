using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideUAPP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReservedPage : ContentPage
	{
        public ObservableCollection<TripViewModel> TourGuides { get; set; }

        public ReservedPage ()
		{
			InitializeComponent ();
            TourGuides = new ObservableCollection<TripViewModel>();
            TourGuides.Add(new TripViewModel
            {
                ID = 0,
                TGName = "Ahmed Samy",
                TGPP = "Assets/tgmaleeepng.png",
                Rating = "Assets/rating.png",
                Nationality = "Egyptian",
                Place = "Egyptian Museum",
                DT = new DateTime(2018, 09, 20)
            });
            TourGuides.Add(new TripViewModel
            {
                ID = 1,
                TGName = "Monica Saeed",
                TGPP = "Assets/tggirll.png",
                Rating = "Assets/rating.png",
                Nationality = "Egyptian",
                Place = "Egyptian Museum",
                DT = new DateTime(2018, 09, 20)
            });

            TourGuides.Add(new TripViewModel
            {
                ID = 2,
                TGName = "Michael Mounir",
                TGPP = "Assets/tgboy.png",
                Rating = "Assets/ratingg.png",
                Nationality = "Egyptian",
                Place = "Egyptian Museum",
                DT = new DateTime(2018, 09, 20)
            });
            TourGuides.Add(new TripViewModel
            {
                ID = 3,
                TGName = "Sara Ezzat",
                TGPP = "Assets/tggirl.PNG",
                Rating = "Assets/ratingg.png",
                Nationality = "Egyptian",
                Place = "Karnak Temple",
                DT = new DateTime(2018, 09, 10)
            });
            TourGuides.Add(new TripViewModel
            {
                ID = 4,
                TGName = "Ebrahim El morshdy",
                TGPP = "Assets/tgboyy.png",
                Rating = "Assets/ratingg.png",
                Nationality = "Egyptian",
                Place = "Hatshepsut Temple",
                DT = new DateTime(2018, 08, 21)
            });
            TourGuides.Add(new TripViewModel
            {
                ID = 5,
                TGName = "Sally Safwat",
                TGPP = "Assets/tggirlll.png",
                Rating = "Assets/ratingg.png",
                Nationality = "Egyptian",
                Place = "Giza Pyramids",
                DT = new DateTime(2018, 08, 01)
            });

            TourGuides.Add(new TripViewModel
            {
                ID = 6,
                TGName = "Mohamed Samir",
                TGPP = "Assets/tgmaleee.png",
                Rating = "Assets/ratinggg.png",
                Nationality = "Egyptian",
                Place = "Abou Simbl Temple",
                DT = new DateTime(2018, 07, 05)
            });

            TourGuides.Add(new TripViewModel
            {
                ID = 7,
                TGName = "Safi Kamal",
                TGPP = "Assets/tggirllll.PNG",
                Rating = "Assets/ratinggg.png",
                Nationality = "Egyptian",
                Place = "Mosque of Ibn Tulun",
                DT = new DateTime(2018, 06, 25)
            });

            TourGuides.Add(new TripViewModel
            {
                ID = 8,
                TGName = "Shahd Amir",
                TGPP = "Assets/tggirlllll.PNG",
                Rating = "Assets/ratinggg.png",
                Nationality = "Egyptian",
                Place = "Valley of the kings",
                DT = new DateTime(2018, 06, 15)
            });

            TourGuides.Add(new TripViewModel
            {
                ID = 9,
                TGName = "Mahmoud Srour",
                TGPP = "Assets/tgboyyy.png",
                Rating = "Assets/ratinggg.png",
                Nationality = "Egyptian",
                Place = "Siwa Oasis",
                DT = new DateTime(2018, 06, 01)
            });

            TourGuides.Add(new TripViewModel
            {
                ID = 10,
                TGName = "Shady Gamal",
                TGPP = "Assets/tgmale.PNG",
                Rating = "Assets/ratinggg.png",
                Nationality = "Egyptian",
                Place = "Saint Catherine Monastery",
                DT = new DateTime(2018, 05, 24)
            });

            TourGuides.Add(new TripViewModel
            {
                ID = 11,
                TGName = "Youssef Mourad",
                TGPP = "Assets/tgmalee.PNG",
                Rating = "Assets/ratinggg.png",
                Nationality = "Egyptian",
                Place = "Elephantine Temple",
                DT = new DateTime(2018, 04, 03)
            });
        }
    }
}