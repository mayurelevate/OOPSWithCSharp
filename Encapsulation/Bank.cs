using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
   public class Bank
    {
        private double balance;

        //public  double getBalance()
        //{
        //    return balance;
        //}

        //public void setBalance(double balance)
        //{
        //    this.balance = balance;
        //}

        public double Balance 
        {             
            get 
            {
                return balance; 
            } 
            set 
            { 
                if(value < 0)
                {
                   Console.WriteLine("Value cannot be Negative");
                }

                this.balance = value; 
            } 
        }

    }
}
