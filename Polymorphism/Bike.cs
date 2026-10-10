using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polymorphism
{
    internal class Bike :Vehicle
    {
        private int _noofWheels;

        public int NoofWheels
        {
            get { return _noofWheels; }

            set
            {
                this._noofWheels = value;
            }
        }

        public override void Start()
        {
            Console.WriteLine("Bike Starts");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike Stops");
        }


        public void DispalyDetails()
        {
            Console.WriteLine($"Bike Name : {Name}");
            Console.WriteLine($"Bike Model : {Model}");
            Console.WriteLine($"Bike Model Year : {Year}");
            Console.WriteLine($"Bike Wheels : {NoofWheels}");
        }
    }
}
