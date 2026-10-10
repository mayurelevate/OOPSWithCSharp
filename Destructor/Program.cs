using System;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            User obj1 = new User();
            User obj2 = new User();
            obj1 = null;
            obj2 = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}
