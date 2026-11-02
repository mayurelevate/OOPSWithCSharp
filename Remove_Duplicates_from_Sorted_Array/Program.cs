using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Input: nums = [1, 1, 2]
            //Output: 2, nums = [1, 2, _]

            int[] result = getnums();

            Console.WriteLine($"Array output : {string.Join(" ", result)}");
            Console.ReadLine();
        }


        public static int[] getnums()
        {
            int[] nums = { 1, 1, 2,3,4,4,5,6,7,7,8};

            int len = nums.Length;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        continue;
                    }
                    else
                    {
                        sb.Append(nums[i]);
                        break;
                    }
                }
            }

            return Array.Empty<int>();
        }
    }
}
