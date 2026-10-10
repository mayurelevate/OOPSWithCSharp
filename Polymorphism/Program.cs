using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car { Name = "BMW", Model = "S", Year = 2025, NoOfWheels = 8, NoOfDoors = 4 });
            vehicles.Add(new Bike { Name = "Appache", Model = "RTR", NoofWheels = 2, Year = 2019 });

            //Vehicle Insepctions

            foreach(var vehicle in vehicles)
            {
                //if(vehicle is Car)
                //{
                //    var car = (Car)vehicle;
                //    car.Start();
                //

                vehicle.Start();
            }


            //var car = new Car();
            //car.Name = "BMW";
            //car.Model = "S";
            //car.Year = 2025;
            //car.NoOfWheels = 8;
            //car.NoOfDoors = 4;
            //car.Start();
            //car.DispalyDetails();
            //car.Stop();

            //var bike = new Bike();
            //bike.Name = "Appache";
            //bike.Model = "RTR";
            //bike.NoofWheels = 2;
            //bike.Year = 2019;
            //bike.Start();
            //bike.DispalyDetails();
            //bike.Stop();



        }
    }
}
