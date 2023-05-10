using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class ServoInfo
    {
        public ushort[] RawValue { get; } = new ushort[17];
    }
}
