using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string msg)
        {
            // To Do : 
            // Write an logic to send the email
            Console.WriteLine("Sending Email :" + msg);
        }
    }

    public class SmsSender : INotificationService
    {
        public void SendNotification(string msg)
        {
            // To Do : 
            // Write an logic to send the txt sms
            Console.WriteLine("Sending Text SMS :" + msg);
        }
    }
}
