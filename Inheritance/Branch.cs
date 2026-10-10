using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Branch
    {
        private int _BranchCode;
        private string _BranchName;
        private string _BranchAddress;

        public int BranchCode 
        {
            get 
            {
                return _BranchCode;
            } 
            set
            {
                //if(value < 0)
                //{
                //    Console.WriteLine("Branch Code Should Not Be : " + value);
                //    return;
                //}
                this._BranchCode = value;
            }
        }

        public string BranchName
        {
            get
            {
                return _BranchName;
            }
            set
            {
                //if(string.IsNullOrEmpty(value))
                //{
                //    Console.WriteLine("Enter Brach")
                //}

                this._BranchName = value;
            }
        }

        public string BranchAddress
        {
            get
            {
                return _BranchAddress;
            }
            set
            {
                this._BranchAddress = value;
            }
        }

        protected void GetBranchData()
        {
            Console.WriteLine("Enter Branch Details");
            
            Console.WriteLine("Enter Branch Code");
            BranchCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Branch Name");
            BranchName = Console.ReadLine();

            Console.WriteLine("Enter Branch Address");
            BranchAddress = Console.ReadLine();
        }

        protected void DisplayBranchDetails()
        {
            Console.WriteLine("Branch Code : " + BranchCode);
            Console.WriteLine("Branch Name: " + BranchName);
            Console.WriteLine("Branch Address: " + BranchAddress);
        }
    }


    public class Employee : Branch
    {

        private int _EmployeeId, _EmployeeAge;
        private string _EmployeeName, _EmployeeAddress;

        public int EmployeeId 
        {
            get
            {
                return _EmployeeId;
            }
            set
            {
                this._EmployeeId = value;
            } 
        }

        public int EmployeeAge 
        { 
            get { return _EmployeeAge; } 
            set { this._EmployeeAge = value; } 
        }

        public string EmployeeName 
        { 
            get { return _EmployeeName; } 
            set { this._EmployeeName = value; } 
        }

        public string EmployeeAddress
        {
            get { return _EmployeeAddress; }
            set { this._EmployeeAddress = value; }
        }


        public void GetEmployeeData()
        {

            base.GetBranchData();            
            Console.WriteLine("Enter Employee Details");

            Console.WriteLine("Enter Employee Id");
            EmployeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Age");
            EmployeeAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee Address");
            EmployeeAddress = Console.ReadLine();
        }

        public void DisplayEmployeeDetails()
        {
            base.DisplayBranchDetails();
            Console.WriteLine("Employee Id : " + EmployeeId);
            Console.WriteLine("Employee Age : " + EmployeeAge);
            Console.WriteLine("Employee Name : " + EmployeeName);
            Console.WriteLine("Employee Address : " + EmployeeAddress);
        }
    }
}
