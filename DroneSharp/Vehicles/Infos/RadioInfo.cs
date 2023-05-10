using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class RadioInfo
    {
        public float RSSI { get; set; }
        public float RemoteRSSI { get; set; }
        public float TxBuffer { get; set; }
        public float RxErrors { get; set; }
        public float Noise { get; set; }
        public float RemoteNoise { get; set; }
        public int FixedPacketCount { get; set; }

    }
}
