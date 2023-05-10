using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class Vibration
    {
        public uint Clip0 { get; set; }
        public uint Clip1 { get; set; }
        public uint Clip2 { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}
