using System;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Area a = new Calculation.Rectangle();
            a.Area(5, 6);

            a = new Calculation.Circle();
            a.Area(7, 0);



            Console.WriteLine("Hello World!");
        }
    }
}
