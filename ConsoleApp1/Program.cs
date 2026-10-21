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


            int[] numbers = { 1, 2, 3, 1, 2, 4, 5, 10, 11, 4, 5, 10, 11 };


            var result = Enumerable.Range(0, numbers.Length - 1)
                .Select(i => new { First = numbers[i], Second = numbers[i + 1] })
                .GroupBy(p => new { p.First, p.Second })
                .Where(g => g.Count() > 1).Select(g => g.Key);




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
