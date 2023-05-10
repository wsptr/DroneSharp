using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class SpeedInfo
    {
        // <summary>Ground X Speed (Latitude, positive north)  [cm/s] </summary>
        /// <summary>
        /// 地速的在纬度方向的分量，单位 cm/s
        /// </summary>
        public float[] Vx { get; } = new float[2];
        /// <summary>Ground Y Speed (Longitude, positive east)  [cm/s] </summary>
        public float[] Vy { get; set; } = new float[2];
        /// <summary>Ground Z Speed (Altitude, positive down)  [cm/s] </summary>
        public float[] Vz { get; set; } = new float[2];

        public float[] GroundSpeed { get; set; } = new float[2];
        public float[] Course { get; set; } = new float[2];

        public float AirSpeed { get; set; }
        public float AirSpeedRatio { get; set; }
        public bool UseAirSpeed { get; set; }
        public float VerticalSpeed { get; set; }
    }
}
