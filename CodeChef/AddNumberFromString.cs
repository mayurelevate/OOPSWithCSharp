using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChef
{
    class AddNumberFromString
    {
       public void Logic()
        {
            string[] data = Console.ReadLine().Trim().Split();

            if (data != null)
            {

                for (int i = 1; i <= Convert.ToInt32(data[0]); i++)
                {
                    int sum = 0;
                    string[] numdata = Console.ReadLine().Trim().Split(' ');

                    foreach (char c in numdata[0])
                    {
                        sum += c - '0';
                    }
                    Console.WriteLine(sum);
                }
                Console.ReadLine();
            }
        }
    }
}
