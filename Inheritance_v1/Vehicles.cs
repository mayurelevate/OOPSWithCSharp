using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_v1
{
    internal class Vehicles
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        public void Start()
        {
            Console.WriteLine("Start Vehicle");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Vehicle");
        }
    }
}
