using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[3];
            customer[0] = new Customer
            {
                Name = "Mark",
                Gender = 1
            };

            customer[1] = new Customer
            {
                Name = "Marry",
                Gender = 2
            };

            customer[2] = new Customer
            {
                Name = "Sam",
                Gender = 0
            };


            foreach(Customer cust in customer)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", cust.Name, GetGender(cust.Gender));
                //Console.WriteLine("Name : " + cust.Name);
                //Console.WriteLine("Gender : " + cust.Gender);                
            }

            Console.Read();
        }

        public static string GetGender(int gender)
        {
            switch(gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected"; 
            }
                
        }
    }


    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }



}
