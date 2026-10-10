using System;

namespace ConstructorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Manage m1 = new Manage();
            m1.DisplayValue();

            Manage m2 = new Manage(100);
            m2.DisplayValue();

            Console.WriteLine("Hello World!");
        }
    }
}
