using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DroneSharp.Vehicles.Infos
{
    public class Sensors
    {
        private BitArray bitArrayEnabled = new BitArray(32);
        private BitArray bitArrayHealth = new BitArray(32);
        private BitArray bitArrayPresent = new BitArray(32);

        #region Enabled
        public bool GyroEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO)] = value;
        }

        public bool AccelerometerEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL)] = value;
        }

        public bool CompassEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG)] = value;
        }

        public bool BarometerEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ABSOLUTE_PRESSURE)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ABSOLUTE_PRESSURE)] =
                value;
        }

        public bool DifferentialPressureEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.DIFFERENTIAL_PRESSURE)];
            set =>
                bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.DIFFERENTIAL_PRESSURE)] =
                    value;
        }

        public bool GpsEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.GPS)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.GPS)] = value;
        }

        public bool OpticalFlowEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.OPTICAL_FLOW)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.OPTICAL_FLOW)] = value;
        }

        public bool VisionPositionNEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.VISION_POSITION)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.VISION_POSITION)] =
                value;
        }

        public bool LaserPositionEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.LASER_POSITION)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.LASER_POSITION)] =
                value;
        }

        public bool GroundTruthEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.EXTERNAL_GROUND_TRUTH)];
            set =>
                bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.EXTERNAL_GROUND_TRUTH)] =
                    value;
        }

        public bool RateControlEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ANGULAR_RATE_CONTROL)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ANGULAR_RATE_CONTROL)] =
                value;
        }

        public bool AttitudeStabilizationEnabled
        {
            get =>
                bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ATTITUDE_STABILIZATION)];
            set =>
                bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ATTITUDE_STABILIZATION)] =
                    value;
        }

        public bool YawPositionEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.YAW_POSITION)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.YAW_POSITION)] = value;
        }

        public bool AltitudeControlEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.Z_ALTITUDE_CONTROL)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.Z_ALTITUDE_CONTROL)] =
                value;
        }

        public bool XyPositionControlEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.XY_POSITION_CONTROL)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.XY_POSITION_CONTROL)] =
                value;
        }

        public bool MotorControlEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MOTOR_OUTPUTS)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MOTOR_OUTPUTS)] = value;
        }

        public bool RcReceiverEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.RC_RECEIVER)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.RC_RECEIVER)] = value;
        }

        public bool Gyro2Enabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO2)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO2)] = value;
        }

        public bool Accel2Enabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL2)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL2)] = value;
        }

        public bool Mag2Enabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG2)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG2)] = value;
        }

        public bool GeofenceEnabled
        {
            get => bitArrayEnabled[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_GEOFENCE)];
            set => bitArrayEnabled[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_GEOFENCE)] = value;
        }

        public bool AhrsEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_AHRS)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_AHRS)] =
                value;
        }

        public bool TerrainEnabled
        {
            get =>
                bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_TERRAIN)];
            set =>
                bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_TERRAIN)] =
                    value;
        }

        public bool RevthrottleEnabled
        {
            get => bitArrayEnabled[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_REVERSE_MOTOR)];
            set => bitArrayEnabled[
                    ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_REVERSE_MOTOR)] =
                value;
        }

        public bool LoggingEnabled
        {
            get =>
                bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_LOGGING)];
            set =>
                bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_LOGGING)] =
                    value;
        }

        public bool BatteryEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.BATTERY)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.BATTERY)] = value;
        }

        public bool ProximityEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.PROXIMITY)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.PROXIMITY)] = value;
        }

        public bool SatcomEnabled
        {
            get => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.SATCOM)];
            set => bitArrayEnabled[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.SATCOM)] = value;
        }

        public bool PrearmEnabled
        {
            get => bitArrayEnabled[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_PREARM_CHECK)];
            set => bitArrayEnabled[
                    ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_PREARM_CHECK)] =
                value;
        }

        public uint ValueEnabled
        {
            get
            {
                var array = new int[1];
                bitArrayEnabled.CopyTo(array, 0);
                return (uint)array[0];
            }
            set
            {
                bitArrayEnabled = new BitArray(new[] { (int)value });
            }
        }
        #endregion Enable

        #region Health
        public bool GyroHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO)] = value;
        }

        public bool AccelerometerHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL)] = value;
        }

        public bool CompassHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG)] = value;
        }

        public bool BarometerHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ABSOLUTE_PRESSURE)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ABSOLUTE_PRESSURE)] =
                value;
        }

        public bool DifferentialPressureHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.DIFFERENTIAL_PRESSURE)];
            set =>
                bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.DIFFERENTIAL_PRESSURE)] =
                    value;
        }

        public bool GpsHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.GPS)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.GPS)] = value;
        }

        public bool OpticalFlowHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.OPTICAL_FLOW)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.OPTICAL_FLOW)] = value;
        }

        public bool VisionPositionNHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.VISION_POSITION)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.VISION_POSITION)] =
                value;
        }

        public bool LaserPositionHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.LASER_POSITION)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.LASER_POSITION)] =
                value;
        }

        public bool GroundTruthHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.EXTERNAL_GROUND_TRUTH)];
            set =>
                bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.EXTERNAL_GROUND_TRUTH)] =
                    value;
        }

        public bool RateControlHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ANGULAR_RATE_CONTROL)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ANGULAR_RATE_CONTROL)] =
                value;
        }

        public bool AttitudeStabilizationHealth
        {
            get =>
                bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ATTITUDE_STABILIZATION)];
            set =>
                bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ATTITUDE_STABILIZATION)] =
                    value;
        }

        public bool YawPositionHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.YAW_POSITION)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.YAW_POSITION)] = value;
        }

        public bool AltitudeControlHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.Z_ALTITUDE_CONTROL)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.Z_ALTITUDE_CONTROL)] =
                value;
        }

        public bool XyPositionControlHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.XY_POSITION_CONTROL)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.XY_POSITION_CONTROL)] =
                value;
        }

        public bool MotorControlHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MOTOR_OUTPUTS)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MOTOR_OUTPUTS)] = value;
        }

        public bool RcReceiverHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.RC_RECEIVER)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.RC_RECEIVER)] = value;
        }

        public bool Gyro2Health
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO2)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO2)] = value;
        }

        public bool Accel2Health
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL2)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL2)] = value;
        }

        public bool Mag2Health
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG2)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG2)] = value;
        }

        public bool GeofenceHealth
        {
            get => bitArrayHealth[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_GEOFENCE)];
            set => bitArrayHealth[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_GEOFENCE)] = value;
        }

        public bool AhrsHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_AHRS)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_AHRS)] =
                value;
        }

        public bool TerrainHealth
        {
            get =>
                bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_TERRAIN)];
            set =>
                bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_TERRAIN)] =
                    value;
        }

        public bool RevthrottleHealth
        {
            get => bitArrayHealth[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_REVERSE_MOTOR)];
            set => bitArrayHealth[
                    ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_REVERSE_MOTOR)] =
                value;
        }

        public bool LoggingHealth
        {
            get =>
                bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_LOGGING)];
            set =>
                bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_LOGGING)] =
                    value;
        }

        public bool BatteryHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.BATTERY)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.BATTERY)] = value;
        }

        public bool ProximityHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.PROXIMITY)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.PROXIMITY)] = value;
        }

        public bool SatcomHealth
        {
            get => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.SATCOM)];
            set => bitArrayHealth[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.SATCOM)] = value;
        }

        public bool PrearmHealth
        {
            get => bitArrayHealth[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_PREARM_CHECK)];
            set => bitArrayHealth[
                    ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_PREARM_CHECK)] =
                value;
        }

        public uint ValueHealth
        {
            get
            {
                var array = new int[1];
                bitArrayHealth.CopyTo(array, 0);
                return (uint)array[0];
            }
            set
            {
                bitArrayHealth = new BitArray(new[] { (int)value });
            }
        }
        #endregion Health

        #region Present
        public bool GyroPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO)] = value;
        }

        public bool AccelerometerPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL)] = value;
        }

        public bool CompassPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG)] = value;
        }

        public bool BarometerPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ABSOLUTE_PRESSURE)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ABSOLUTE_PRESSURE)] =
                value;
        }

        public bool DifferentialPressurePresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.DIFFERENTIAL_PRESSURE)];
            set =>
                bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.DIFFERENTIAL_PRESSURE)] =
                    value;
        }

        public bool GpsPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.GPS)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.GPS)] = value;
        }

        public bool OpticalFlowPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.OPTICAL_FLOW)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.OPTICAL_FLOW)] = value;
        }

        public bool VisionPositionNPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.VISION_POSITION)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.VISION_POSITION)] =
                value;
        }

        public bool LaserPositionPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.LASER_POSITION)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.LASER_POSITION)] =
                value;
        }

        public bool GroundTruthPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.EXTERNAL_GROUND_TRUTH)];
            set =>
                bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.EXTERNAL_GROUND_TRUTH)] =
                    value;
        }

        public bool RateControlPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ANGULAR_RATE_CONTROL)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ANGULAR_RATE_CONTROL)] =
                value;
        }

        public bool AttitudeStabilizationPresent
        {
            get =>
                bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ATTITUDE_STABILIZATION)];
            set =>
                bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.ATTITUDE_STABILIZATION)] =
                    value;
        }

        public bool YawPositionPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.YAW_POSITION)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.YAW_POSITION)] = value;
        }

        public bool AltitudeControlPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.Z_ALTITUDE_CONTROL)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.Z_ALTITUDE_CONTROL)] =
                value;
        }

        public bool XyPositionControlPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.XY_POSITION_CONTROL)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.XY_POSITION_CONTROL)] =
                value;
        }

        public bool MotorControlPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MOTOR_OUTPUTS)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MOTOR_OUTPUTS)] = value;
        }

        public bool RcReceiverPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.RC_RECEIVER)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.RC_RECEIVER)] = value;
        }

        public bool Gyro2Present
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO2)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_GYRO2)] = value;
        }

        public bool Accel2Present
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL2)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_ACCEL2)] = value;
        }

        public bool Mag2Present
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG2)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR._3D_MAG2)] = value;
        }

        public bool GeofencePresent
        {
            get => bitArrayPresent[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_GEOFENCE)];
            set => bitArrayPresent[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_GEOFENCE)] = value;
        }

        public bool AhrsPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_AHRS)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_AHRS)] =
                value;
        }

        public bool TerrainPresent
        {
            get =>
                bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_TERRAIN)];
            set =>
                bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_TERRAIN)] =
                    value;
        }

        public bool RevthrottlePresent
        {
            get => bitArrayPresent[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_REVERSE_MOTOR)];
            set => bitArrayPresent[
                    ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_REVERSE_MOTOR)] =
                value;
        }

        public bool LoggingPresent
        {
            get =>
                bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_LOGGING)];
            set =>
                bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_LOGGING)] =
                    value;
        }

        public bool BatteryPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.BATTERY)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.BATTERY)] = value;
        }

        public bool ProximityPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.PROXIMITY)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.PROXIMITY)] = value;
        }

        public bool SatcomPresent
        {
            get => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.SATCOM)];
            set => bitArrayPresent[ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.SATCOM)] = value;
        }

        public bool PrearmPresent
        {
            get => bitArrayPresent[
                ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_PREARM_CHECK)];
            set => bitArrayPresent[
                    ConvertValuetoBitmaskOffset((int)MAVLink.MAV_SYS_STATUS_SENSOR.MAV_SYS_STATUS_PREARM_CHECK)] =
                value;
        }

        public uint ValuePresent
        {
            get
            {
                var array = new int[1];
                bitArrayPresent.CopyTo(array, 0);
                return (uint)array[0];
            }
            set
            {
                bitArrayPresent = new BitArray(new[] { (int)value });
            }
        }
        #endregion Present

        public float MagOffsetX { get; set; }
        public float MagOffsetY { get; set; }
        public float MagOffsetZ { get; set; }
        public float MagDeclination { get; set; }
        public float RawPressure { get; set; }
        public float RawTemperature { get; set; }
        public float GyroCalX { get; set; }
        public float GyroCalY { get; set; }
        public float GyroCalZ { get; set; }
        public float AccelCalX { get; set; }
        public float AccelCalY { get; set; }
        public float AccelCalZ { get; set; }


        private int ConvertValuetoBitmaskOffset(int input)
        {
            var offset = 0;
            for (var a = 0; a < sizeof(int) * 8; a++)
            {
                offset = 1 << a;
                if (input == offset)
                    return a;
            }

            return 0;
        }

        public override string ToString()
        {
            return Convert.ToString(ValueEnabled, 2);
        }
    }
}
