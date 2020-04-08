using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleParking.Interfaces;
using VehicleParking.Src;

namespace VehicleParking
{
    class Program
    {
        static void Main(string[] args)
        {
            IEcharges c = new Car();
            c.Duration = 2;

            IEcharges b = new Bike();
            b.Duration = 2;

            IEcharges t = new Truck();
            t.Duration = 2;

            Console.WriteLine("Charges Car for 2 hours = " + c.charges());
            Console.WriteLine("Charges Bike for 2 hours = " + b.charges());
            Console.WriteLine("Charges Truck for 2 hours = " + t.charges());
            Console.ReadLine();
        }
    }
}