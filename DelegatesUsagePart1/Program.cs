using System;
using System.Collections.Generic;

namespace DelegatesUsagePart1
{

    //interface PromoteFunction
    //{

    //    void PromoteEmp(List<Employee> obj);

    //}
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> objList = new List<Employee>();

            objList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            objList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            objList.Add(new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
            objList.Add(new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            Employee obj = new Employee();

            IsPormotable objIsPormotable = new IsPormotable(Promote);
            obj.PromoteEmployee(objList,objIsPormotable);
            //obj.PromoteEmp(objList);
        }


        public static bool Promote(Employee obj)
        {
            if (obj.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    


    delegate bool IsPormotable(Employee obj);
    

   class Employee //: PromoteFunction
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public void PromoteEmployee(List<Employee> objEmployeeLst,IsPormotable IsEligibleToPromote)
        {
           foreach(Employee emp in  objEmployeeLst)
            {
                if(IsEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name + " Promoted");                   
                }
            }

            Console.ReadLine();
        }


        //interface method
       //public void PromoteEmp(List<Employee> obj)
       // {
       //     foreach (Employee emp in obj)
       //     {
       //         if (emp.Experience >= 5)
       //         {
       //             Console.WriteLine(emp.Name + " Promoted");
       //         }
       //     }

       //     Console.WriteLine("Interface Method Use");
       //     Console.ReadLine();
       // }
    }
}

















