using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterConstructor
{
    class employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


        public employee(int Id,string FName,string LName,string Addr)
        {
            this.EmpId = Id;
            this.FirstName = FName;
            this.LastName = LName;
            this.Address = Addr;
            int z = Add(Id);

        }

        public void DisplayInfo()
        {
            Console.WriteLine("Employee Id: " + this.EmpId);
            Console.WriteLine("Employee First Name: " + this.FirstName);
            Console.WriteLine("Employee Last Name: " + this.LastName);
            Console.WriteLine("Employee Address: " + this.Address);
        }

        public  int Add(int a)
        {
            int b = a + a;

            return b;
        }

    }
}
