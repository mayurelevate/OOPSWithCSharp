using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();

            string CarName = obj.CarName;
            string CarColor = obj.CarColor;

            obj.Start();
            obj.Steering();
            obj.Break();
            obj.Gear();

            Console.WriteLine("Hello World!");
        }
    }
}
