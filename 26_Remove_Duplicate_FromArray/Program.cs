using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Remove_Duplicate_FromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 1, 2};

            Array.Sort(num);

            int k =1;

            for(int i =1; i< num.Length;i++)
            {
                if(num[i] != num[i - 1])
                {
                    num[k] = num[i];
                    k = k + 1;
                }
            }

            Console.WriteLine($"Unique Elements : {k}");


        }
    }
}
