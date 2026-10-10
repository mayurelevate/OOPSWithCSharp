using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReturnDataUsingThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResultCallbackDelegate resultCallbackDelegate = new ResultCallbackDelegate(ResultCallbackMethod);

            int Number = 10;

            NumberHelper obj = new NumberHelper(Number, resultCallbackDelegate);

            Thread t1 = new Thread(new ThreadStart(obj.CalculateSum));

            t1.Start();
            Console.Read();
        }
        
        public static void ResultCallbackMethod(int Result)
        {
            Console.WriteLine("The Result is " + Result);
        }
    }
}
