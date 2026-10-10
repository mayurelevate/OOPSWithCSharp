using System;

namespace DigitSeparator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Without Using digit separators
            long x = 1001;
            long z = 1001001;

            Console.WriteLine("X : {0}", x);
            Console.WriteLine("Y : {0}", z);

            // Using digit separators

            long num1 = 100_1;
            long num2 = 1001_10_0_1;


            Console.WriteLine("Num1 : {0}", num1);
            Console.WriteLine("Num2 : {0}", num2);





        }
    }
}
