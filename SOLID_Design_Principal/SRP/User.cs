using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal
{
    // This is SRP - Single Responsibility Principle 

    // User Class responsible for capture the data only
    public class User
    {
        public string username  { get; set; }
        public string email { get; set; }
        
    }

    //User Service class responsible for User Related Business Operations..
    public class UserService
    {
        public void RegisterUser(User user)
        {
            Console.WriteLine("User Registered");

            Console.WriteLine("Email notification");

            EmailSender emailSender = new EmailSender();

            emailSender.SendEmail(user.email, "Welcome to our platform");
        }
    }
}
