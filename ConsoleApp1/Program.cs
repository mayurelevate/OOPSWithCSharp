using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execute Statement1\n");

            goto statement4;
            Console.WriteLine("Execute Statement2");
            Console.WriteLine("Execute Statement3");

            statement4:
            Console.WriteLine("Execute Statement4\n");
            Console.WriteLine("Execute Statement5\n");
            Console.ReadKey();
        }
    }
}
