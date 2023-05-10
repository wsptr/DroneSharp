using System;
using System.Collections.Generic;
using System.Text;
using static MAVLink;

namespace DroneSharp.Vehicles.Infos
{
    public class GpsInfo
    {
        public GPS_FIX_TYPE GpsFixType { get; set; } = GPS_FIX_TYPE.NO_GPS;
        public int SatCount { get; set; }
        public float HDOP { get; set; }
        public float GDOP { get; set; }
        public float HAcc { get; set; }
        public float VAcc { get; set; }
        public float VelAcc { get; set; }
        public float HdgAcc { get; set; }
        public float Yaw { get; set; }

    }
}
