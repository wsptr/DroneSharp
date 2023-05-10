using DroneSharp.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MAVLink;

namespace DroneSharp.Vehicles
{
    public class FixedWing : Plane
    {
        internal readonly Dictionary<PLANE_MODE, string> _ModeStrings = new Dictionary<PLANE_MODE, string>()
        {
            {PLANE_MODE.ACRO,"特技模式" },
            {PLANE_MODE.AUTO,"自动模式" },
            {PLANE_MODE.AUTOTUNE,"自动调参模式" },
            {PLANE_MODE.AVOID_ADSB,"AVOID ADSB" },
            {PLANE_MODE.CIRCLE,"盘旋模式" },
            {PLANE_MODE.CRUISE,"巡航模式" },
            {PLANE_MODE.FLY_BY_WIRE_A,"线控A模式" },
            {PLANE_MODE.FLY_BY_WIRE_B,"线控B模式" },
            {PLANE_MODE.GUIDED,"引导模式" },
            {PLANE_MODE.INITIALIZING,"初始化" },
            {PLANE_MODE.LOITER,"留待模式" },
            {PLANE_MODE.MANUAL,"手动模式" },
            {PLANE_MODE.QACRO,"垂起特技模式" },
            {PLANE_MODE.QAUTOTUNE,"垂起自动调参模式" },
            {PLANE_MODE.QHOVER,"垂起悬停模式" },
            {PLANE_MODE.QLAND,"垂起着陆模式" },
            {PLANE_MODE.QLOITER,"垂起留待模式" },
            {PLANE_MODE.QRTL,"垂起返航模式" },
            {PLANE_MODE.QSTABILIZE,"垂起增稳模式" },
            {PLANE_MODE.RTL,"返航模式" },
            {PLANE_MODE.STABILIZE,"增稳模式" },
            {PLANE_MODE.TAKEOFF,"起飞模式" },
            {PLANE_MODE.THERMAL,"热气流模式" },
            {PLANE_MODE.TRAINING,"训练模式" },
        };

        


        public FixedWing(byte sysId, ISerial link, MAVLink.MAV_TYPE type) 
            : base(sysId, link, type)
        {
        }

        private string GetMode(PLANE_MODE mode)
        {
            if (_ModeStrings.ContainsKey(mode))
                return _ModeStrings[mode];
            else
                return string.Empty;
        }

        public override string GetMode(int modeCode)
        {
            return GetMode((PLANE_MODE)modeCode);
        }

        public override string[] GetModes()
        {
            return _ModeStrings.Values.ToArray();
        }

        public override Task<bool> Land()
        {
            throw new NotImplementedException();
        }

        public override Task<bool> TakeOff(int altitude)
        {
            throw new NotImplementedException();
        }

        protected override uint TranslateModeString(string mode)
        {
            throw new NotImplementedException();
        }

        public override bool SetMode(int modeCode)
        {
            return SetMode(_ModeStrings[(PLANE_MODE)modeCode]);
        }

        public override bool SetMode(string mode)
        {
            PLANE_MODE planeMode= PLANE_MODE.RTL;
            if (Enum.TryParse<PLANE_MODE>(mode, true, out planeMode))
            {
                // TODO: 添加设置代码
                return true;
            }
            else
                return false;
        }
    }
}
