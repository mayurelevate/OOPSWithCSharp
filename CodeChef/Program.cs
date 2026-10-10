using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChef
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] count = Console.ReadLine().Trim().Split();

            int loopcount = Convert.ToInt32(count[0]);


            for(int i=0; i< loopcount;i++)
            {
                int number = Convert.ToInt32(Console.ReadLine().Trim());
                int root = 1;
                int j = 0;

                while(true)
                {
                    j = j + 1;
                    root = (number / root + root) / 2;
                    if(j == number + 1)
                    {
                        break;
                    }                
                }
                Console.WriteLine(root);
            }








          
            
        }
    }
}
