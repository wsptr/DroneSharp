using System;
using System.Collections.Generic;
using System.Text;
using static MAVLink;

namespace DroneSharp.Vehicles.Infos
{
    public class SystemInfo
    {
        public float Load { get; set; }

        public ushort PacketDropRemote { get; set; }
        public ushort[] ErrorCount { get; private set; } = new ushort[4];
        public Sensors Sensors { get; private set; } = new Sensors();
        public bool TerrainActivated => Sensors.TerrainHealth && Sensors.TerrainEnabled && Sensors.TerrainPresent;
        public bool SafetyActivated => !Sensors.MotorControlEnabled;
        public MAV_VTOL_STATE VTOLState { get; set; }
        public MAV_LANDED_STATE LandState { get; set; }
    }
}
