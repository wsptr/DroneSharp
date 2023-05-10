using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles
{
    partial class Vehicle
    {
        public override string ToString()
        {
            return $"Vehicle {Name}";
        }

        protected abstract uint TranslateModeString(string mode);
        public abstract string[] GetModes();
        public abstract string GetMode(int modeCode);
        public abstract bool SetMode(int modeCode);
        public abstract bool SetMode(string mode);
    }
}
