using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class RearrangeArray
    {

        public void reArrange()
        {
            // int[] numbers = new int[] { 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            // int[] numbers = new int[] { 1,2,3,4};
            int[] numbers = new int[] { 1 ,9 ,2, 8, 3, 7, 4, 6, 5 };



            //Array.Sort(numbers);

            if (numbers.Length > 0)
            {

                int count = (numbers.Length / 2);

                for (int i = 0; i <= count; i++)
                {
                    if (i == count)
                    {
                        Console.Write($" {numbers[i]}");
                        break;
                    }
                    else
                    {
                        int num = numbers.Length - 1;

                        Console.Write($" {numbers[i]} {numbers[num - i]}");
                    }
                }
            }

            //Array.Sort(numbers);
            //int start = 0;
            //int end = numbers.Length - 1;
            //int[] nums = new int[numbers.Length];
            //int k = 0;
            //while (start <= end && k < numbers.Length - 1)
            //{
            //    nums[k] = numbers[start];
            //    nums[k + 1] = numbers[end];
            //    start++;
            //    end--;
            //    k += 2;
            //}
            //if (numbers.Length % 2 != 0)
            //{
            //    nums[k] = numbers[start++];
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    numbers[i] = nums[i];
            //}
        }
    }
}
