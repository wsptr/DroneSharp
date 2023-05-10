using System;
using System.Collections.Generic;
using System.Text;
using static MAVLink;

namespace DroneSharp.Vehicles.Infos
{
    internal class Helper
    {
        public static bool IsGlobalFrame(mavlink_mission_item_int_t cmd)
        {
            switch ((MAV_FRAME)cmd.frame)
            {
                case MAV_FRAME.GLOBAL:
                case MAV_FRAME.GLOBAL_INT:
                case MAV_FRAME.GLOBAL_RELATIVE_ALT:
                case MAV_FRAME.GLOBAL_RELATIVE_ALT_INT:
                case MAV_FRAME.GLOBAL_TERRAIN_ALT:
                case MAV_FRAME.GLOBAL_TERRAIN_ALT_INT:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsLocalFrame(mavlink_mission_item_int_t cmd)
        {
            switch ((MAV_FRAME)cmd.frame)
            {
                case MAV_FRAME.LOCAL_ENU:
                case MAV_FRAME.LOCAL_FLU:
                case MAV_FRAME.LOCAL_FRD:
                case MAV_FRAME.LOCAL_NED:
                case MAV_FRAME.LOCAL_OFFSET_NED:
                    return true;
                default:
                    return false;
            }
        }

        public static bool Is1E7Frame(mavlink_mission_item_int_t cmd)
        {
            switch ((MAV_FRAME)cmd.frame)
            {
                case MAV_FRAME.GLOBAL_INT:
                case MAV_FRAME.GLOBAL_RELATIVE_ALT_INT:
                case MAV_FRAME.GLOBAL_TERRAIN_ALT_INT:
                    return true;
                default:
                    return false;
            }
        }

        public static bool Is1E4Frame(mavlink_mission_item_int_t cmd)
        {
            switch ((MAV_FRAME)cmd.frame)
            {
                case MAV_FRAME.LOCAL_ENU:
                case MAV_FRAME.LOCAL_FLU:
                case MAV_FRAME.LOCAL_FRD:
                case MAV_FRAME.LOCAL_NED:
                case MAV_FRAME.LOCAL_OFFSET_NED:
                    return true;
                default:
                    return false;
            }
        }

        public static double GetFrameFactor(mavlink_mission_item_int_t cmd)
        {
            switch ((MAV_FRAME)cmd.frame)
            {
                case MAV_FRAME.GLOBAL_INT:
                case MAV_FRAME.GLOBAL_RELATIVE_ALT_INT:
                case MAV_FRAME.GLOBAL_TERRAIN_ALT_INT:
                case MAV_FRAME.GLOBAL:
                case MAV_FRAME.GLOBAL_RELATIVE_ALT:
                case MAV_FRAME.GLOBAL_TERRAIN_ALT:
                    return 1e7;
                case MAV_FRAME.LOCAL_ENU:
                case MAV_FRAME.LOCAL_FLU:
                case MAV_FRAME.LOCAL_FRD:
                case MAV_FRAME.LOCAL_NED:
                case MAV_FRAME.LOCAL_OFFSET_NED:
                    return 1e4;
                default:
                    return 1;
            }
        }

        public static double GetFrameFactor(mavlink_mission_item_t cmd)
        {
            switch ((MAV_FRAME)cmd.frame)
            {
                case MAV_FRAME.GLOBAL_INT:
                case MAV_FRAME.GLOBAL_RELATIVE_ALT_INT:
                case MAV_FRAME.GLOBAL_TERRAIN_ALT_INT:
                    return 1e7;
                case MAV_FRAME.LOCAL_ENU:
                case MAV_FRAME.LOCAL_FLU:
                case MAV_FRAME.LOCAL_FRD:
                case MAV_FRAME.LOCAL_NED:
                case MAV_FRAME.LOCAL_OFFSET_NED:
                    return 1e4;
                default:
                    return 1;
            }
        }
    }
}
