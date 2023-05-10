using System;
using System.Collections.Generic;
using System.Text;
using static MAVLink;

namespace DroneSharp.Vehicles.Infos
{
    public class PowerInfo
    {
        public float BoardVoltage { get; set; }
        public float ServoVoltage { get; set; }
        public float BatteryRemaining { get; set; }
        public float Current { get; set; }
        public float Current2 { get; set; }
        public MAV_POWER_STATUS VoltageFlag { get; set; }
        public BatteryInfo BatteryInfo { get; } = new BatteryInfo();
    }
}
