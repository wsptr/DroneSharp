using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DroneSharp.Vehicles
{
    internal interface IPlane
    {
        Task<bool> TakeOff(int altitude);
        Task<bool> Land();
    }
}
