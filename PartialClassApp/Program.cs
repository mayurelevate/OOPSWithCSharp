using System;

namespace PartialClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialEmployee emp = new PartialEmployee();
            emp.FirstName = "Mayur";
            emp.LastName = "Naktode";
            emp.Salary = 1000000;
            emp.Gender = "Male";
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();

            Console.WriteLine("Hello World!");
        }
    }
}
