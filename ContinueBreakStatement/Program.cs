using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueBreakStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for(int i=1;i<=10;i++)
            {
                //if(i==6)
                //{
                //    continue;
                //}
                //Console.WriteLine(i);

                if(i!=6)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
