using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class reverseArray
    {
        public void fun_reverse_array()
        {
            int[] numberlist =  new int[] { 1, 2, 3, 4 };

            int array_length = numberlist.Length;

            Console.Write($"Lenght of array :  { array_length }");

            int[] new_num_list = new int[numberlist.Length];

            for(int i=0;i<numberlist.Length;i++)
            {
                new_num_list[i] = numberlist[array_length - i - 1];
            }

            foreach(int num in new_num_list)
            {
                Console.Write($"array list {num}");
            }
        }
    }
}
