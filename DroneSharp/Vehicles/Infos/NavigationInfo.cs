using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class NavigationInfo
    {
        public float DesiredRollDegree { get; set; }
        public float DesiredPitchDegree { get; set; }
        public float DesiredHeadingDegree { get; set; }
        public float TargetHeadingDegree { get; set; }
        public float WaypointDistance { get; set; }
        public float AltitudeError { get; set; }
        public float AirspeedError { get; set; }
        public float CrossTrackError { get; set; }
    }
}
