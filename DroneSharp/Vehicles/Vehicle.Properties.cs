using DroneSharp.Links;
using DroneSharp.Vehicles.Infos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static MAVLink;

namespace DroneSharp.Vehicles
{
    partial class Vehicle
    {
        public string Name { get; set; }
        public byte SysId { get; protected set; }
        public static byte GcsId { get; set; } = 255;
        public MAV_TYPE Type { get; protected set; }
        public MAV_AUTOPILOT AutoPilotType { get; protected set; }
        public MAV_STATE Status { get; protected set; }
        protected UInt32 _Mode { get; set; }
        public UInt32 ModeCode => _Mode;
        public string Mode { get; protected set; } = String.Empty;
        public int MavlinkVersion { get; protected set; } = 2;
        protected byte _SystemStatus { get; set; }
        public Version Version { get; protected set; }
        public UInt64 UID { get; private set; }
        public string UIDStr { get; private set; }
        public MAVLink.MAV_PROTOCOL_CAPABILITY Capabilities { get; private set; }
        public int TTL { get; protected set; }
        public PointLatLngAlt PositionLatLngAlt { get; } = new PointLatLngAlt();
        public PointLatLngAlt PositionLatLngAlt2 { get; } = new PointLatLngAlt();
        public bool PositionValid { get; set; } = false;
        public Point3DF PositionNed { get; } = new Point3DF();
        public Attitude Attitude { get; } = new Attitude();
        public float Heading { get; protected set; }
        public NavigationInfo NavigationInfo { get; protected set; } = new NavigationInfo();
        public bool Armed { get; protected set; }
        public bool FailSafe => _SystemStatus == (byte)MAVLink.MAV_STATE.CRITICAL;
        public int[] RC_Channels { get; } = new int[33];
        public float Throttle { get; protected set; }
        public int RSSI { get; protected set; }
        public PointLatLngAlt HomeLocation { get; } = new PointLatLngAlt();
        public PointLatLngAlt TargetLocation { get; set; }
        public MAVLink.FENCE_BREACH FenceBreachType { get; set; } = FENCE_BREACH.NONE;
        public float OpticalFlow_m_X { get; protected set; }
        public float OpticalFlow_m_Y { get; protected set; }
        public short OpticalFlow_X { get; protected set; }
        public short OpticalFlow_Y { get; protected set; }
        public byte OpticalFlowQuality { get; protected set; }
        public Vibration Vibe { get; } = new Vibration();
        public DateTime GpsTime { get; protected set; } = DateTime.MinValue;
        public EkfInfo EKF { get; } = new EkfInfo();
        public Dictionary<byte, RangeFinder> RangeFinders { get; } = new Dictionary<byte, RangeFinder>()
        {
            {0 , new RangeFinder(0)},
            {1 , new RangeFinder(1)},
            {2 , new RangeFinder(2)}
        };

        public EFI EFI { get; } = new EFI();
        public WindInfo WindInfo { get; } = new WindInfo();
        public SystemInfo SystemInfo { get; } = new SystemInfo();
        public PowerInfo PowerInfo { get; } = new PowerInfo();
        private List<(DateTime time, string message)> messages { get; } = new List<(DateTime, string)>();
        public PressureInfo PressureInfo { get; } = new PressureInfo();
        public SpeedInfo SpeedInfo { get; } = new SpeedInfo();
        public GpsInfo GpsInfo { get; } = new GpsInfo();
        public GpsInfo GpsInfo2 { get; } = new GpsInfo();
        public int HeadingToWp { get; protected set; }
        public RadioInfo RadioInfo { get; } = new RadioInfo();
        public ServoInfo ServoMain { get; } = new ServoInfo();
        public ServoInfo ServoAux { get; } = new ServoInfo();
        public string StatusText { get; protected set; }
        public string LinkName => _Link != null ? _Link.ConnectionString : String.Empty;
        public string TypeName
        {
            get
            {
                switch (Type)
                {

                    case MAVLink.MAV_TYPE.FIXED_WING:
                        {
                            return "固定翼";
                        }
                    case MAVLink.MAV_TYPE.VTOL_FIXEDROTOR:
                    case MAVLink.MAV_TYPE.VTOL_TAILSITTER_DUOROTOR:
                    case MAVLink.MAV_TYPE.VTOL_TAILSITTER_QUADROTOR:
                    case MAVLink.MAV_TYPE.VTOL_TILTROTOR:
                        {
                            return "垂直起降固定翼";
                        }
                    case MAVLink.MAV_TYPE.HELICOPTER:
                        {
                            return "直升机";
                        }
                    case MAVLink.MAV_TYPE.QUADROTOR:
                        {
                            return "四旋翼";
                        }
                    case MAVLink.MAV_TYPE.HEXAROTOR:
                        {
                            return "六旋翼";
                        }
                    case MAVLink.MAV_TYPE.OCTOROTOR:
                        {
                            return "八旋翼";
                        }
                    case MAVLink.MAV_TYPE.DECAROTOR:
                    case MAVLink.MAV_TYPE.DODECAROTOR:
                        {
                            return "多旋翼";
                        }
                    case MAVLink.MAV_TYPE.GROUND_ROVER:
                        {
                            return "车辆";
                        }
                    default:
                        {
                            return "未知";
                        }
                }
            }
        }

        private PointLatLngAlt _movingbase = new PointLatLngAlt();
        public PointLatLngAlt MovingBase
        {
            get => _movingbase;
            set
            {
                if (value == null)
                    _movingbase = new PointLatLngAlt();

                if (_movingbase.Latitude != value.Latitude || _movingbase.Longitude != value.Longitude || _movingbase.Altitude
                    != value.Altitude)
                    _movingbase = value;
            }
        }

        Dictionary<string, mavlink_param_value_t> _Params = new Dictionary<string, mavlink_param_value_t>();
        public Dictionary<string, mavlink_param_value_t> Params => _Params;
    }
}
