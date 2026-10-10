using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_v1
{
    internal class Bike :Vehicles
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


        public void DispalyDetails()
        {
            Console.WriteLine($"Bike Name : {Name}");
            Console.WriteLine($"Bike Model : {Model}");
            Console.WriteLine($"Bike Model Year : {Year}");
            Console.WriteLine($"Bike Wheels : {NoofWheels}");
        }
    }
}
