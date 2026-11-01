using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2 = new Test();

            Employee obj = new Employee();
        }
    }

    public class Test
    {

        public Test()
        {
            Console.WriteLine("Constructor Test");
        }

        static Test()
        {
            Console.WriteLine("From Static Constructor");
        }
    }


    // Static Field Initialization Order

    public class Employee
    {

        static int x = GetValue();


        static int GetValue()
        {
            Console.WriteLine("get Value");
            return 10;
        }



        public Employee()
        {
            Console.WriteLine($"Constructor with getvalues function values : {x}");
        }
    }


}
