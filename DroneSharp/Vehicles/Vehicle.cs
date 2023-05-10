using DroneSharp.Links;
using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles
{
    public abstract partial class Vehicle
    {
        public Vehicle(byte sysId,ISerial link,MAVLink.MAV_TYPE type)
        {
            this.SysId = sysId;
            Type = type;
        }
    }
}
