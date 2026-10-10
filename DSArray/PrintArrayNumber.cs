using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class PrintArrayNumber
    {
        public void numbers()
        {
            int[] numbers = new int[] {1,2,3,4,5};

            if(numbers.Length >0)
            {
                for(int i=0;i < numbers.Length;i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
