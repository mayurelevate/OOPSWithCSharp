using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewTestProgram
{
    class ClsFibonacciNumber
    {

        public static int NthFibonacciNumber(int n)
        {
            if (n <=1)
            {
                return n;
            }
            else
            {
                //int a = (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
                return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
            }
        }











    }
}
