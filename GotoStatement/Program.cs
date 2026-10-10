using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            System.Console.WriteLine("A");
            System.Console.WriteLine("B");
            System.Console.WriteLine("C");
            System.Console.WriteLine("D");

            if(i==1)
            {
                goto repeat_string;
            }
            System.Console.WriteLine("E");
            System.Console.WriteLine("F");
            System.Console.WriteLine("G");
            repeat_string:
            System.Console.WriteLine("After GO To");
            System.Console.WriteLine("H");

            Console.ReadKey();
        }
    }
}
