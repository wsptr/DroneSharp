using System;
using System.Collections.Generic;
using System.Text;
using DroneSharp.Links;
using DroneSharp.Vehicles.Infos;

namespace DroneSharp.Vehicles
{
    partial class Vehicle
    {
        Guid _Guid = Guid.NewGuid();
        protected DateTime _LastHeartbeatTime = DateTime.MinValue;
        internal Sensors _Sensors = new Sensors();
        internal float _Multiplierspeed = 1;
        ISerial _Link;
        bool _Started = false;
    }
}
