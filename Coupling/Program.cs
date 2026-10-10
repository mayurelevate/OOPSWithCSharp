using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Order order = new Order(new EmailSender()); // here we send notification via email
            Order order = new Order(new SmsSender()); // here we send notification via sms/txt msg 
            order.PlaceOrder();

        }
    }
}
