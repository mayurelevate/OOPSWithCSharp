using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class DynamicSizeArray
    {

        public void DynamicArray()
        {

            List<int> list_num = new List<int>();

            list_num.Add(1);
            list_num.Add(2);
            list_num.Add(3);
            list_num.Add(4);
            list_num.Add(5);


            Console.Write("Array Element Are : ");

            for(int i=0; i< list_num.Count; i++)
            {
                Console.Write($"{list_num[i]} ");
            }
        }
    }
}
