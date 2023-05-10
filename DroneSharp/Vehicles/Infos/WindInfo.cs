using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class WindInfo
    {
        public bool Valid { get; set; }
        public float Direction { get; set; }
        public float Velocity { get; set; }
    }
}
