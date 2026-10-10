using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionClassMethodApp
{
   public abstract class MyClass
    {
        public abstract void calculate(double x);
    }


    class Sub1 : MyClass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("Square Root is" + Math.Sqrt(x));
        }
    }


    class Sub2 : MyClass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("Square is : " + (x * x));
        }
    }

    class Sub3 : MyClass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("CUBE is: " + (x * x * x));
        }
    }
}
