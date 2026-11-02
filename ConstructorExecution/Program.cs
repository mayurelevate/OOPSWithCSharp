using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExecution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee objEmp = new Employee();
            objEmp.MethodA();

            Student objStudent = new Student();
            objStudent.MethodA();

            Employee objEmp1 = new Student();
            objEmp1.MethodA();



        }
    }


    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Employee Constructor");
        }

        public void MethodA()
        {
            Console.WriteLine("Method A from Employee");
        }
    }


    public class Student : Employee
    {
        public Student()
        {
            Console.WriteLine("Student Constructor");
        }

        public new void MethodA()
        {
            Console.WriteLine("Method A From Student");
        }

        public void MethodB()
        {
            Console.WriteLine("Method B From Student");
        }
    }
}
