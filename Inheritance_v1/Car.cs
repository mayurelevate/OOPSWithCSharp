using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_v1
{
    internal class Car : Vehicles
    {
        private int _noOfDoors;
        private int _noofWheels;
        public int NoOfDoors 
        {
            get
            {
                return this._noOfDoors;
            }

            set
            {
                this._noOfDoors = value;
            }
        }

        public int NoOfWheels
        {
            get
            {
                return this._noofWheels;
            }

            set
            {
                this._noofWheels = value;
            }
        }

        public void DispalyDetails()
        {
            Console.WriteLine($"Car Name : {Name}");
            Console.WriteLine($"Car Model : {Model}");
            Console.WriteLine($"Car Model Year : {Year}");
            Console.WriteLine($"Car Doors : {NoOfDoors}");
            Console.WriteLine($"Car Wheels : {NoOfWheels}");
        }

    }
}
