using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public Employee()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("Enter Employee Id");
            this.EmpId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee First Name");
            this.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Employee Last Name");
            this.LastName = Console.ReadLine();

            Console.WriteLine("Enter Employee Address");
            this.Address = Console.ReadLine();
        }

        public Employee(Employee obj)
        {
            this.EmpId = obj.EmpId;
            this.FirstName = obj.FirstName;
            this.LastName = obj.LastName;
            this.Address = obj.Address;
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Enter Employee Id : " + this.EmpId);
            Console.WriteLine("Enter Employee First Name : " + this.FirstName);
            Console.WriteLine("Enter Employee Last Name : " + this.LastName);
            Console.WriteLine("Enter Employee Address : " + this.Address);
        }

    }
}
