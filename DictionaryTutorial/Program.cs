using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DictionaryTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Cust1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer Cust2 = new Customer()
            {
                ID = 102,
                Name = "Sara",
                Salary = 6000
            };

            Customer Cust3 = new Customer()
            {
                ID = 103,
                Name = "Todd",
                Salary = 7000
            };

            Dictionary<int, Customer> dictCustomer = new Dictionary<int, Customer>();
            dictCustomer.Add(Cust1.ID, Cust1);
            dictCustomer.Add(Cust2.ID, Cust2);
            dictCustomer.Add(Cust3.ID, Cust3);

            if(!dictCustomer.ContainsKey(Cust1.ID))
            {
                dictCustomer.Add(Cust1.ID, Cust1);
            }


           Customer cust =  dictCustomer[101];

            foreach (KeyValuePair<int,Customer> item in dictCustomer)
            {
                if(dictCustomer.ContainsKey(item.Key))
                {
                    Console.WriteLine("ID= {0}, Name = {1} , Salary ={2}", item.Value.ID, item.Value.Name, item.Value.Salary);
                    Console.WriteLine("----------------------------------------------------");
                }                
            }
            Console.ReadLine();

            //Console.WriteLine("ID= {0}, Name = {1} , Salary ={2}", cust.ID, cust.Name, cust.Salary);
            //Console.ReadLine();

        }
    }


    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
