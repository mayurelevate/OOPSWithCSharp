using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B objB = new B();
            objB.Func1();


            //method Casting
            ((A)objB).Func1();

            A objA = new B();
            objA.Func1();

        }
    }

    public class A
    {
        public void Func1()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public new void Func1()
        {
            Console.WriteLine("B");
        }
    }


}
