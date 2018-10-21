using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using GuideUAPP;

namespace GuideUAPP
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            customMap.RouteCoordinates.Add(new Position(30.063850, 31.348063));
            customMap.RouteCoordinates.Add(new Position(30.064982, 31.347655));
            customMap.RouteCoordinates.Add(new Position(30.065075, 31.349007));
            customMap.RouteCoordinates.Add(new Position(30.063608, 31.349222));
            customMap.RouteCoordinates.Add(new Position(30.063163, 31.345145));
            customMap.RouteCoordinates.Add(new Position(30.069310, 31.344201));
            customMap.RouteCoordinates.Add(new Position(30.069619, 31.346175));
            customMap.RouteCoordinates.Add(new Position(30.069823, 31.345853));
            customMap.RouteCoordinates.Add(new Position(30.067454, 31.325070));
            customMap.RouteCoordinates.Add(new Position(30.080638, 31.316315));
            customMap.RouteCoordinates.Add(new Position(30.069571, 31.291982));
            customMap.RouteCoordinates.Add(new Position(30.077444, 31.279580));
            customMap.RouteCoordinates.Add(new Position(30.068976, 31.265460));
            customMap.RouteCoordinates.Add(new Position(30.067881, 31.260954));
            customMap.RouteCoordinates.Add(new Position(30.066897, 31.253981));
            customMap.RouteCoordinates.Add(new Position(30.064872, 31.252929));

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(30.063850, 31.348063), Distance.FromKilometers(1.0)));
        }
    }
}