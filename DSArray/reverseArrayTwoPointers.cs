using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class reverseArrayTwoPointers
    {
        public void reversTwoPointer()
        {
            int[] num_list = new int[] { 1, 2, 3, 4, 5, 6 ,7};

            int temp =0,start=0,end = num_list.Length-1;

            while(start < end)
            {
                temp = num_list[start];
                num_list[start] = num_list[end];
                num_list[end] = temp;
                start++;
                end--;
            }

            foreach(int num in num_list)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
