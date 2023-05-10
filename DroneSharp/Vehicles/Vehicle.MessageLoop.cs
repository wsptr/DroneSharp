using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DroneSharp.Vehicles
{
    partial class Vehicle
    {


        private void ThdMessageLoop()
        {
            MAVLink.MavlinkParse parse= new MAVLink.MavlinkParse();
            while(_Started)
            {
                var packet = parse.ReadPacket(_Link.BaseStream);
                if (packet == null)
                {
                    Thread.Sleep(1);
                    continue;
                }


            }
        }
    }
}
