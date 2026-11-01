using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorWithVirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            //obj.func1();
        }
    }

    public class A
    {
        public A()
        {
            Console.WriteLine("Constructor A");
        }
        public virtual void func1()
        {
            Console.WriteLine("function 1 from A class");
        }
    }

    public class B : A
    {
        private string name = "Mayur";
        private readonly string name1;
        public B()
        {
            name = "Developer";
            name1 = "Developer1";
            Console.WriteLine("Constructor B");
        }
        public override void func1()
        {           
            Console.WriteLine($"name :{name} | name1 : {name1}");
        }
    }

}
