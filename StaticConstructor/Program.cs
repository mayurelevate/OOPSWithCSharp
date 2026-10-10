using System;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {

            Manage m1 = new Manage();
            m1.Display();
            m1.Display();

            Manage m2 = new Manage();
            m2.Display();
            m2.Display();


            Console.WriteLine("Hello World!");
        }
    }
}
