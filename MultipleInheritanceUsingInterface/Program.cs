using System;

namespace MultipleInheritanceUsingInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            //InterfaceImplementation obj = new InterfaceImplementation();


            //((Interface1)obj).Test();
            //((Interface1)obj).Show();

            //((Interface2)obj).Test();
            //((Interface2)obj).Show();



            //Interface1 I1 = new InterfaceImplementation();
            //I1.Test();
            //I1.Show();

            //Interface2 I2 = new InterfaceImplementation();
            //I2.Test();
            //I2.Show();



            //-----------------------------------------


            DerivedClass objDerivedClass = new DerivedClass();
            objDerivedClass.Interface3Method();
            objDerivedClass.BaseClassMethod();



        }
    }
}
