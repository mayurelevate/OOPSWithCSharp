using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class ReverseByInbuidFunction
    {

        public void reverse_inbuild()
        {
            int[] numlist =  new  int[6] { 5, 3, 6, 4, 1, 2 };

            Array.Reverse(numlist);

            //Print array values

            foreach(int num in numlist)
            {
                Console.Write($"{num } ");
            }

        }
    }
}
