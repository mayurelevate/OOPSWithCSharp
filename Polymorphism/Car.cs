using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polymorphism
{
    internal class Car :Vehicle
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

        public override void Start()
        {
            Console.WriteLine("Car Starts");
        }

        public override void Stop()
        {
            Console.WriteLine("Car Stops");
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
