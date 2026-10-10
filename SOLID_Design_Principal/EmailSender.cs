using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal
{
    internal class EmailSender
    {
        public void SendEmail(string email,string msg)
        {
            Console.WriteLine($"Email Id : {email} , Message : {msg} ");
        }
    }
}
