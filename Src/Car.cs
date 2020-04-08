using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleParking.Interfaces;

namespace VehicleParking.Src
{
    class Car : IEcharges
    {
        public int Duration { get; set; }

        public int charges()
        {
            return this.Duration * 5;
        }
    }
}
