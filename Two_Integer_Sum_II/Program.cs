using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Integer_Sum_II
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] result = getTwoSum();

            Console.WriteLine($"Array output : {string.Join(" ",result)}");
            Console.ReadLine();
        }


        public static int[] getTwoSum()
        {
            int[] numbers = { 1,2,3,4 };

            int target = 6;
            int left = 0;
            int right = numbers.Length - 1;

            while(left < right)
            {

                int sum = numbers[left] + numbers[right];

                if(target == sum)
                {
                    return new int[] { left+1, right +1 };
                }
                else if(sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }




            }





            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] + numbers[j] == output)
            //        {
            //            return new int[] { i + 1, j + 1 };
            //        }
            //    }
            //}

            return Array.Empty<int>();
        }
    }
}
