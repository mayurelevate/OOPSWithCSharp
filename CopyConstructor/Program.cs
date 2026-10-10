using System;

namespace CopyConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee e1 = new Employee();
                Employee e2 = new Employee(e1);
                e1.DisplayInfo();
                e2.DisplayInfo();

                Console.WriteLine("Hello World!");
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
