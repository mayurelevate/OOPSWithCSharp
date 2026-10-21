using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumbers
{

    // missing number in array
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 6,8,1,2,4,6,9,10 };

            Array.Sort(num);

            int length = num.Length;

            StringBuilder sb = new StringBuilder();

            for(int i=0; i < length -1; i++)
            {

                for (int j = num[i] + 1; j < num[i + 1]; j++) 
                {
                    sb.Append(j).Append(",");
                }

                //if ((num[i + 1] - num[i]) > 1)
                //{
                //    int first_value = num[i];
                //    int last_value = num[i + 1];

                //    while (first_value < last_value)
                //    {
                //        sb.Append(first_value + 1);
                //        sb.Append(",");
                //        first_value++;
                //        last_value--;
                //    }
                //}
            }


            Console.WriteLine($"Missing Number : {sb.ToString().TrimEnd(',')}");
        }
    }
}
