using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdaterelated
{

    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }

    class Program : I1,I2
    {

        static void Main(string[] args)
        {

            //Program p1 = new Program();
            //((I1)p1).InterfaceMethod();
            //((I2)p1).InterfaceMethod();

            //I1 i1 = new Program();
            //I2 i2 = new Program();

            //i1.InterfaceMethod();
            //i2.InterfaceMethod();

            Program p = new Program();
            p.InterfaceMethod();

            ((I2)p).InterfaceMethod();



            //var today = DateTime.Today;
            //var month = new DateTime(today.Year, today.Month, 1);
            //var first = month.AddMonths(-1);
            //var last = month.AddDays(-1);

        }

        // -- Explicity Implementation
        //void I1.InterfaceMethod()
        //{
        //    Console.WriteLine("I1 Interface Method");
        //    Console.ReadLine();
        //}


        // -- Default Implementation
       public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
            Console.ReadLine();
        }



        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
            Console.ReadLine();
        }
    }
}
