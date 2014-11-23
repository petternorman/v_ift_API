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
	        Time = DateTime.UtcNow;
        }

        public double Lat { get; set; }

        public double Lng { get; set; }

		public DateTime Time { get; set; }
    }
}