using System;
using System.Collections.Generic;
using System.Linq;
using v_ift.Models;

namespace v_ift.Classes
{
    /// <summary>
    /// Calculates distances between geographical points based upon the 
    /// Haversine formula (http://en.wikipedia.org/wiki/Haversine_formula).
    /// Haversine formula is less correct than Vincenty, but also less expensive.
    /// This implementation was based upon http://damien.dennehy.me/blog/2011/01/15/haversine-algorithm-in-csharp/
    /// </summary>
    public class CalculateDistance : ICalculateDistance
    {
        public CalculateDistance()
        {
            
        }

        public decimal GetDistanceBetween(List<Coordinate> coordinates)
        {
            return coordinates.Select((t, i) => this.GetDistanceBetween(t, coordinates[i + 1])).Sum();
        }

        /// <summary>
        /// Radius of the Earth in meters.
        /// </summary>
        private const double EarthRadiusM = 6371000;

        /// <summary>
        /// Converts an angle to a radian.
        /// </summary>
        /// <param name="input">The angle that is to be converted.</param>
        /// <returns>The angle in radians.</returns>
        private double ToRad(double input)
        {
            return input * (Math.PI / 180);
        }

        /// <summary>
        /// Calculates the distance between two geo-points in meters using the Haversine algorithm.
        /// </summary>
        /// <param name="point1">The first point.</param>
        /// <param name="point2">The second point.</param>
        /// <returns>A double indicating the distance between the points in meters.</returns>
        public decimal GetDistanceBetween(Coordinate point1, Coordinate point2)
        {
            var dLat = ToRad(point2.Lat - point1.Lat);
            var dLon = ToRad(point2.Lng - point1.Lng);

            var a = Math.Pow(Math.Sin(dLat / 2), 2) +
                 Math.Cos(ToRad(point1.Lat)) * Math.Cos(ToRad(point2.Lat)) *
                 Math.Pow(Math.Sin(dLon / 2), 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            var distance = EarthRadiusM * c;

            return (decimal) distance;
        }
    }
}