using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank obj = new Bank();
            obj.Balance = -500;
            Console.WriteLine(obj.Balance);
            
            Console.WriteLine("Hello World!");
        }
    }
}
