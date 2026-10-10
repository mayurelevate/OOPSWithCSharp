using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class User
    {
        public User()
        {

        }

        public User(string Name)
        {
            Console.WriteLine(Name);
        }



        public string EmployeeName()
        {

            User obj = new User("Mayur");
          
            return "Mayur";

        }
    }
}
