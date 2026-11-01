using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class ModifyElements
    {
            
        public static void ElementModify()
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            int n = arr.Length;

            const int incrementValue = 5;  


            for(int i=0; i<n; i++)
            {
                int temp = 0;
                temp = incrementValue + arr[i];

                arr[i] =temp;
            }

            Console.WriteLine($"Print Array List {string.Join(" ", arr)}");
        }
    }
}
   