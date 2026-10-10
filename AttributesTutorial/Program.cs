using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            //sum= Calculator.Add(10, 20);
            sum = Calculator.Add(new List<int>() { 10, 20, 30 });
            Console.Write("Addition of two numbers : " + sum);
            Console.Read();
        }
    }


    public class Calculator
    {
        // to show that the method is old 
        [Obsolete("Use Add(List<int> Numbers) Method")]
        public static int Add(int FN,int SN)
        {
            return FN + SN;
        }

        public static int Add(List<int> Numbers)
        {
            int add = 0;

            foreach(int num in  Numbers)
            {
                add = add + num;
            }

            return add;
        }


    }


}
