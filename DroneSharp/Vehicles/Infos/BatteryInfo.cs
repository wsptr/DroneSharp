using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class BatteryInfo
    {
        public float[] Cells { get; } = new float[16];
        public float[] UsedmAh { get; } = new float[16];
        public float[] Remaining { get; } = new float[16];
        public float[] RemainMinute { get; } = new float[16];
        public float[] Voltage { get; } = new float[16];
        public float[] Temperature { get; } = new float[16];
        public float[] Current { get; } = new float[16];
    }
}
