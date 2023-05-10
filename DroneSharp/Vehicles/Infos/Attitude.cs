using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class Attitude
    {
        public float Roll { get; set; }
        public float Pitch { get; set; }
        public float Yaw { get; set; }
        public float AngleOfAttack { get; set; }
        public float SlideSlipAngle { get; set; }
    }
}
