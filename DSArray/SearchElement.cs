using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class SearchElement
    {

        public static void findElement()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int target = 30;

            bool element_found = false;

            for(int i=0; i < arr.Length;i++)
            {
                if (arr[i] == target)
                {
                    
                    element_found = true;
                    break;
                }
            }

            if(element_found)
            {
                Console.WriteLine($"Target element Found : {target}");
            }
            else
            {
                Console.WriteLine("Target element NOT Found");
            }

            Console.ReadLine();



            
            //return element_found;
        }
    }
}
