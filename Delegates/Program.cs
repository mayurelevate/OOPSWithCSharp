using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public delegate string HellDelegateMethod(string _mystring);

   public class Program
    {
        static void Main(string[] args)
        {

            Program obj = new Program();
            //obj.HelloFunction("Hello World");

            HellDelegateMethod del = new HellDelegateMethod(obj.HelloFunction);
            string output = del("2");
            Console.Write(output);
            Console.ReadLine();

        }

        public string HelloFunction(string Message)
        {
            int a = 2;

            a = a + Convert.ToInt32(Message);

            return a.ToString();

            //Console.WriteLine(a.ToString());
            //Console.ReadLine();
        }


    }
}
