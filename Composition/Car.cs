using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Car
    {
        private Engine engine = new Engine();
        private Chassis chassis = new Chassis();
        private Seats seats = new Seats();
        private Wheels wheels = new Wheels();

        public void Start()
        {
            engine.Start();
            wheels.Rotate();
            chassis.Support();
            seats.Sit();
            Console.WriteLine("Engine Starts");
        }

    }
}
