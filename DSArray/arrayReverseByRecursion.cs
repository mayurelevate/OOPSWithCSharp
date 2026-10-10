using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    public class arrayReverseByRecursion
    {

        public void arrayreverseRecursion()
        {

            //int[] numbers = new int[] { 1, 2, 3, 5, 6 };

            int[] numbers =  { 1, 2, 3, 5, 6,7 };

            int start_index_value = 0;

            int end_index_value = numbers.Length - 1;

            arrayrecursion(numbers,start_index_value,end_index_value);


            foreach(int item in numbers)
            {
                Console.Write($"values : {item}");
            }
        }


        public static void arrayrecursion(int[] numbers, int start,int end)
        {

            int temp;

            if (start >= end)
                return;

            temp = numbers[start];
            numbers[start] = numbers[end];
            numbers[end] = temp;

            arrayrecursion(numbers, start+1, end-1);
        }

    }
}
