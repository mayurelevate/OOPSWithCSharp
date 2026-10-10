using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class User
    {
        public User()
        {
            Console.WriteLine("constructor object created");
        }
        ~User()
        {
            Console.WriteLine("object is destroyed");
        }
    }
}
