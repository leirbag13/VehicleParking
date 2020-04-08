using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParking.Interfaces
{
    interface IEcharges
    {

        int Duration
        {
            get;
            set;
        }

        int charges();
    }
}
