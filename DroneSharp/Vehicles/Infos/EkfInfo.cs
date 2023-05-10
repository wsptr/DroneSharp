using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class EkfInfo
    {
        public float Status { get; set; }

        public int Flags { get; set; }

        public float VelocityVariance { get; set; }

        public float CompassVariance { get; set; }

        public float PositionHorizontalVariance { get; set; }

        public float PositionVerticalVariance { get; set; }

        public float TerrainAltitudeVariance { get; set; }
    }
}
