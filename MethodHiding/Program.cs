using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{

    public class Parent
    {
        public virtual void show()
        {
            Console.WriteLine("Parent class show method");
        }

        public void Display()
        {
            Console.WriteLine("Parent Class Display Method");
        }
    }


    public class Child : Parent
    {
        public override void show()
        {
            Console.WriteLine("Child Class Show Method");
        }

        public new void Display()
        {
            Console.WriteLine("Child Class Display Method");
        }

    }





    internal class Program
    {
        static void Main(string[] args)
        {

            Child obj = new Child();
            obj.show(); // overridden
            obj.Display(); //method hidding
            Console.Read();

        }
    }
}
