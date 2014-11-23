using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v_ift.Models
{
    public class Coordinate
    {
        public Coordinate(double lat, double lng)
        {
            this.Lat = lat;
            this.Lng = lng;
        }

        public double Lat { get; set; }

        public double Lng { get; set; }
    }
}