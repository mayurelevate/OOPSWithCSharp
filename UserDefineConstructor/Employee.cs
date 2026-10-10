using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineConstructor
{
    class Employee
    {
        public int eId { get; set; }
        public int eage { get; set; }
        public string ename { get; set; }
        public string eAddress { get; set; }
        
        public Employee()
        {
            this.eId = 1008;
            this.eage = 28;
            this.ename = "MAYUR";
            this.eAddress = "BERLIN";
            return;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Employee Id " + this.eId);
            Console.WriteLine("Employee Name " + this.ename);
            Console.WriteLine("Employee Age " + this.eage);
            Console.WriteLine("Employee Address " + this.eAddress);
        }


        public Employee EmployeeInfo()
        {
            Employee obj = new Employee();
            obj.eId = this.eId;
            obj.ename = this.ename;
            obj.eage = this.eage;
            obj.eAddress = this.eAddress;
            return obj;
        }


    }
}
