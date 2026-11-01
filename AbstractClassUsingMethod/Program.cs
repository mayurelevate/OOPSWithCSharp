using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassUsingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Sub1 objSub1 = new Sub1();
            //objSub1.calculate(9);

            //Sub2 objSub2 = new Sub2();
            //objSub2.calculate(9);

            //Sub3 objSub3 = new Sub3();
            //objSub3.calculate(9);

            //------------------------------------------

            ClsManager cm = new ClsManager();
            cm.GetEmpData();
            cm.DisplayEmpData();

            Console.WriteLine("Hello World!");
        }
    }
}
