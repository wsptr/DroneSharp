using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class RangeFinder
    {
        public byte ID { get; set; }
        public float Range { get; set; }
        public float Voltage { get; set; }
        public uint CurrentDistance { get; set; }

        public RangeFinder(byte id)
        {
            ID = id;
        }
    }
}
