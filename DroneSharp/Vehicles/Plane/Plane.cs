using DroneSharp.Links;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DroneSharp.Vehicles
{
    public abstract class Plane : Vehicle, IPlane
    {
        protected Plane(byte sysId, ISerial link, MAVLink.MAV_TYPE type) : base(sysId, link, type)
        {
        }

        public abstract Task<bool> Land();

        public abstract Task<bool> TakeOff(int altitude);
    }
}
