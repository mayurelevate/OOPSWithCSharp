using System;

namespace ExtensionMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OldClass obj = new OldClass();
            obj.Test1();
            obj.Test2();
            //Calling exrension methods
            obj.Text3();
            obj.Text4(10);
            obj.Text5();
            obj.Text6(6);
            Console.ReadLine();
        }
    }
}
