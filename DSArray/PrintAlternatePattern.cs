using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class PrintAlternatePattern
    {
        public void PrintAlterPtrn()
        {
            int[] arr_num = new int[5] { 1, 2, 3, 4, 5 };

            if(arr_num.Length > 0)
            {
                for(int i=0;i< arr_num.Length;i++)
                {
                    if (arr_num[i]%2!=0)
                    {
                        Console.Write(arr_num[i] + " ");
                    }
                }
            }


        }
    }
}
