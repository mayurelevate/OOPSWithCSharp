using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        public virtual void Start()
        {
            Console.WriteLine("Start Vehicle");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stop Vehicle");
        }
    }
}
