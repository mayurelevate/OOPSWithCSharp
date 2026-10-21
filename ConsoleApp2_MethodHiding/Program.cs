using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_MethodHiding
{
    internal class Program
    {

        //Because this is method hiding, not method overriding.BaseClass b1 = new DerivedClass() 
        //means the actual object is DerivedClass, but the reference type is BaseClass.
        //Since function1() is hidden using the new keyword, method selection is based on 
        //the reference type at compile time, so BaseClass's method is called. If I use virtual 
        //in the base class and override in the derived class, then runtime polymorphism applies 
        //and the DerivedClass method will be called.

        static void Main(string[] args)
        {
            BaseClass b1 = new DerivedClass();
            b1.function1();

            DerivedClass d1 = new DerivedClass();
            d1.function1();

            /// Virtual 

            DerivedV2 obj = new DerivedV2();
            obj.function1();

            BaseV1 objB1 = new DerivedV2();
            objB1.function1();

            BaseV1 objB11 = new BaseV1();
            objB11.function1();
        }
    }


    public class BaseClass
    {
        public void function1()
        {
            Console.WriteLine("From Base Class");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void function1()
        {
            Console.WriteLine("From Derived Class");
        }
    }


    public class BaseV1
    {
        public virtual void function1()
        {
            Console.WriteLine("Virtual from base v1");
        }
    }

    public class DerivedV2 : BaseV1 
    {
        public override void function1()
        {
            //base.function1();
            Console.WriteLine("Override from derived v1");
        }

    }

}
