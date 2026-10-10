using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChef
{
    class SmallFactorial
    {

        public void factorial()
        {
            //Int32 t = Int32.Parse(Console.ReadLine());
            //int fact =1 ;
            //while (t-- > 0)
            //{
            //    fact = 1;
            //    Int32 num = Int32.Parse(Console.ReadLine());
            //    while (num > 1)
            //    {
            //        fact *= num;
            //        num--;
            //    }
            //    Console.WriteLine(fact);
            //}


            string[] data = Console.ReadLine().Trim().Split();
            int Loopcount = Convert.ToInt32(data[0]);
            while (Loopcount != 0)
            {

                string[] facnumber = Console.ReadLine().Split();

                int f = 1;

                for (int i = 1; i <= Convert.ToInt32(facnumber[0]); i++)
                {
                    f = f * i;
                }

                Loopcount--;
                Console.WriteLine(f);

            }
            Console.ReadLine();
        }
    }
}
