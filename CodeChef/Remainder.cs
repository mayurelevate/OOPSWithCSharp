using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChef
{
    class Remainder
    {
        public void Rmdr()
        {
            Console.WriteLine("Enter No : ");
            string[] data = Console.ReadLine().Split(' ');

            int LoopCount = Convert.ToInt32(data[0]);

            while (LoopCount != 0)
            {

                string[] number = Console.ReadLine().Split(' ');


                int num1 = Convert.ToInt32(number[0]);
                int num2 = Convert.ToInt32(number[1]);
                int result = 0;

                result = num1 % num2;

                LoopCount--;
                Console.WriteLine(result);
            }
        }
    }
}
