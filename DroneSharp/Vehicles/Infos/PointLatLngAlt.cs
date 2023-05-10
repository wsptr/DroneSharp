using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class PointLatLngAlt
    {
        public static readonly PointLatLngAlt Zero = new PointLatLngAlt();

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }
        public double AltitudeAbsolute { get; set; }
        public string Tag { get; set; }

        public PointLatLngAlt(double lat, double lng, double alt, string tag)
        {
            Latitude = lat;
            Longitude = lng;
            Altitude = alt;
            Tag = tag;
        }

        public PointLatLngAlt(double lat, double lng, double alt)
            : this(lat, lng, alt, string.Empty)
        {
        }

        public PointLatLngAlt()
        {
        }

        public PointLatLngAlt(double[] pos)
            : this(pos[0], pos[1], pos[2])
        {
        }

        public override string ToString()
        {
            return $"{Latitude},{Longitude},{Altitude}";
        }
    }
}
