using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedType
{
    public class Customer
    {
        protected int ID = 101;
        public void PrintID()
        {
            Console.WriteLine(this.ID);
        }        
    }

    public class CorporateCustomer : Customer
    {
        public void PrintCustomerId()
        {
            base.ID = 12;
            CorporateCustomer obj = new CorporateCustomer();
            Console.WriteLine(obj.ID);

          

            Console.WriteLine(this.ID);

            Console.WriteLine(base.ID);
        }
    }


    public class RetailCustomer
    {
        public void PrintCustomerId()
        {
            RetailCustomer obj = new RetailCustomer();
            
        }
    }
}
