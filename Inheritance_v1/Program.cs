using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Name = "BMW";
            car.Model = "S";
            car.Year = 2025;
            car.NoOfWheels = 8;
            car.NoOfDoors = 4;
            car.Start();
            car.DispalyDetails();
            car.Stop();

            var bike = new Bike();
            bike.Name = "Appache";
            bike.Model = "RTR";
            bike.NoofWheels = 2;
            bike.Year = 2019;
            bike.Start();
            bike.DispalyDetails();
            bike.Stop();


        }
    }
}
