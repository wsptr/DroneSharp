using DroneSharp.Links;
using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles
{
    internal class Rotor : Plane
    {
        public Rotor(byte sysId, ISerial link, MAVLink.MAV_TYPE type) : base(sysId, link, type)
        {
        }

        public override string GetMode(int modeCode)
        {
            throw new NotImplementedException();
        }

        public override string[] GetModes()
        {
            throw new NotImplementedException();
        }

        public override bool Land()
        {
            throw new NotImplementedException();
        }

        public override bool SetMode(int modeCode)
        {
            throw new NotImplementedException();
        }

        public override bool SetMode(string mode)
        {
            throw new NotImplementedException();
        }

        public override bool TakeOff(int altitude)
        {
            throw new NotImplementedException();
        }

        protected override uint TranslateModeString(string mode)
        {
            throw new NotImplementedException();
        }
    }
}
