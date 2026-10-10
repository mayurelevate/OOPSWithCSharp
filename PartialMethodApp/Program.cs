using System;

namespace PartialMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass obj = new PartialClass();
            obj.PublicMethod();
            Console.WriteLine("Hello World!");
        }
    }
}
