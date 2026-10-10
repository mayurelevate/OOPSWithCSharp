using System;

namespace UserDefineConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.DisplayInfo();

            obj = obj.EmployeeInfo();

            Console.WriteLine("Employee Name In Main Method : " + obj.ename);
            Console.WriteLine("Main Method");
            Console.ReadKey();
        }
    }
}
