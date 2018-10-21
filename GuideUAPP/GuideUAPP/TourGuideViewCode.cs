using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace GuideUAPP
{
    public class TourGuideViewCode : ContentPage
    {

        public ObservableCollection<TripViewModel> TourGuides { get; set; }

        public TourGuideViewCode()
        {
            //NavigationPage.SetHasNavigationBar(this, false);
            TourGuides = new ObservableCollection<TripViewModel>();
            ListView lstView = new ListView();
            lstView.RowHeight = 80;
            
            lstView.ItemTemplate = new DataTemplate(typeof(CustomTourGuideCell));
            TourGuides.Add(new TripViewModel { TGName = "Ahmed Samy", TGPP = "Assets/tgmaleeepng.png", Rating = "Assets/rating.png" });
            TourGuides.Add(new TripViewModel { TGName = "Monica Saeed", TGPP = "Assets/tggirll.png", Rating = "Assets/rating.png" });
            TourGuides.Add(new TripViewModel { TGName = "Michael Mounir", TGPP = "Assets/tgboy.png", Rating = "Assets/ratingg.png" });
            TourGuides.Add(new TripViewModel { TGName = "Sara Ezzat", TGPP = "Assets/tggirl.PNG", Rating = "Assets/ratingg.png" });
            TourGuides.Add(new TripViewModel { TGName = "Ebrahim El morshdy", TGPP = "Assets/tgboyy.png", Rating = "Assets/ratingg.png" });
            TourGuides.Add(new TripViewModel { TGName = "Sally Safwat", TGPP = "Assets/tggirlll.png", Rating = "Assets/ratingg.png" });
            TourGuides.Add(new TripViewModel { TGName = "Mohamed Samir", TGPP = "Assets/tgmaleee.png", Rating = "Assets/ratinggg.png" });
            TourGuides.Add(new TripViewModel { TGName = "Safi Kamal", TGPP = "Assets/tggirllll.PNG", Rating = "Assets/ratinggg.png" });
            TourGuides.Add(new TripViewModel { TGName = "Shahd Amir", TGPP = "Assets/tggirlllll.PNG", Rating = "Assets/ratinggg.png" });
            TourGuides.Add(new TripViewModel { TGName = "Mahmoud Srour", TGPP = "Assets/tgboyyy.png", Rating = "Assets/ratinggg.png" });
            TourGuides.Add(new TripViewModel { TGName = "Shady Gamal", TGPP = "Assets/tgmale.PNG", Rating = "Assets/ratinggg.png" });
            TourGuides.Add(new TripViewModel { TGName = "Youssef Mourad", TGPP = "Assets/tgmalee.PNG", Rating = "Assets/ratinggg.png" });
          
            lstView.ItemsSource = TourGuides;
            lstView.ItemSelected += listView_ItemSelected;
            Content = lstView;
        }

        public class CustomTourGuideCell : ViewCell
        {

            public CustomTourGuideCell()
            {
                //instantiate each of our views
                var image = new Image();
                
                
                var nameLabel = new Label();
               
                var rating = new Image();
                var verticaLayout = new StackLayout();
                var horizontalLayout = new StackLayout() { BackgroundColor = Color.White };


                //set bindings
                nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
                image.SetBinding(Image.SourceProperty, new Binding("Image"));
                rating.SetBinding(Image.SourceProperty, new Binding("Rating"));



                //Set properties for desired design
                nameLabel.VerticalOptions = LayoutOptions.Center;
                horizontalLayout.Orientation = StackOrientation.Horizontal;
                horizontalLayout.HorizontalOptions = LayoutOptions.Fill;
                verticaLayout.VerticalOptions = LayoutOptions.Center;
                image.HorizontalOptions = LayoutOptions.Start;
                image.HeightRequest = 50;
                image.WidthRequest = 50;
                rating.WidthRequest = 100;
                rating.HeightRequest = 40;
                rating.HorizontalOptions = LayoutOptions.Start;
                nameLabel.FontSize = 24;
                nameLabel.VerticalOptions = LayoutOptions.Center;
                nameLabel.HorizontalOptions = LayoutOptions.Center;



                //add views to the view hierarchy
                verticaLayout.Children.Add(nameLabel);
                verticaLayout.Children.Add(rating);
                horizontalLayout.Children.Add(image);
                horizontalLayout.Children.Add(verticaLayout);



                // add to parent view
                View = horizontalLayout;
                

            }
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           
        }
    }
}
