using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace GuideUAPP
{
    class MainMap : Map
    {
        public List<Pins> CustomPins { get; set; }

        public List<Position> RouteCoordinates { get; set; }

        public MainMap()
        {
            RouteCoordinates = new List<Position>();
        }
    }
}
