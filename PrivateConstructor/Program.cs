using System;

namespace PrivateConstructor
{
    class Program
    {
        private Program()
        {
            Console.WriteLine("This Is Private Constructor");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello World!");
        }
    }
}
