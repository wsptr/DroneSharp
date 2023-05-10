using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class EFI
    {
        public float BarometricPressure { get; set; }
        public float CylinderHeadTemperature { get; set; }
        public float EngineLoad { get; set; }
        public byte Health { get; set; }
        public float ExhastGasTemperature { get; set; }
        public float IntakeManifoldTemperature { get; set; }
        public float RPM { get; set; }
        public float FuelFlow { get; set; }
        public float FuelConsumed { get; set; }
    }
}
