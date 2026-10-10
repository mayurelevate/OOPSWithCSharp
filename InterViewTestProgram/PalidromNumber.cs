using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewTestProgram
{
    internal class PalidromNumber
    {
        public static void FindPalindromNumber()
        {
            int r, n, sum = 0, temp;


            Console.Write("Enter a string to Check Palindrome : ");
            n = int.Parse(Console.ReadLine());
            temp = n;

             while(n > 0)
            {

                r = n / 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }

             if(temp == sum)
            {
                Console.WriteLine("Palindrom");
            }
             else
            {
                Console.WriteLine("Not Palindrom");
            }
        }
    }
}
