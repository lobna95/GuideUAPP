using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace GuideUAPP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class gotoMap : ContentPage
	{
		public gotoMap ()
		{
            InitializeComponent();

            var pin2 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(30.048057, 31.233645),
                Label = "Egyptian Museum Cairo",
                Address = "15 Meret Basha, Ismailia, Qasr an Nile, Cairo Governorate",
                Id = "Xamarin2",
                Url = ""
            };

            GoTo.CustomPins = new List<CustomPin> { pin2 };
            GoTo.Pins.Add(pin2);

            var pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(30.063871, 31.347978),
                Label = "National Council for Women",
                Address = "Al Manteqah as Sadesah, Nasr City, Cairo Governorate",
                Id = "Xamarin",
                Url = ""
            };

            GoTo.CustomPins = new List<CustomPin> { pin };
            GoTo.Pins.Add(pin);

            GoTo.RouteCoordinates.Add(new Position(30.063850, 31.348063));
            GoTo.RouteCoordinates.Add(new Position(30.064982, 31.347655));
            GoTo.RouteCoordinates.Add(new Position(30.065075, 31.349007));
            GoTo.RouteCoordinates.Add(new Position(30.063608, 31.349222));
            GoTo.RouteCoordinates.Add(new Position(30.063163, 31.345145));
            GoTo.RouteCoordinates.Add(new Position(30.069310, 31.344201));
            GoTo.RouteCoordinates.Add(new Position(30.069619, 31.346175));
            GoTo.RouteCoordinates.Add(new Position(30.069823, 31.345853));
            GoTo.RouteCoordinates.Add(new Position(30.067454, 31.325070));
            GoTo.RouteCoordinates.Add(new Position(30.080638, 31.316315));
            GoTo.RouteCoordinates.Add(new Position(30.069571, 31.291982));
            GoTo.RouteCoordinates.Add(new Position(30.077444, 31.279580));
            GoTo.RouteCoordinates.Add(new Position(30.068976, 31.265460));
            GoTo.RouteCoordinates.Add(new Position(30.067881, 31.260954));
            GoTo.RouteCoordinates.Add(new Position(30.066897, 31.253981));
            GoTo.RouteCoordinates.Add(new Position(30.064872, 31.252929));
            GoTo.RouteCoordinates.Add(new Position(30.062449, 31.247518));
            GoTo.RouteCoordinates.Add(new Position(30.061799, 31.246682));
            GoTo.RouteCoordinates.Add(new Position(30.061354, 31.245566));
            GoTo.RouteCoordinates.Add(new Position(30.050977, 31.234667));
            GoTo.RouteCoordinates.Add(new Position(30.049538, 31.232822));
            GoTo.RouteCoordinates.Add(new Position(30.048600, 31.234195));
            GoTo.RouteCoordinates.Add(new Position(30.046898, 31.234482));
            GoTo.RouteCoordinates.Add(new Position(30.046722, 31.233656));

            GoTo.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(30.063850, 31.348063), Distance.FromKilometers(1.0)));
        }
    }
}