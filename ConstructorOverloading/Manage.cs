using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    class Manage
    {
        int x;

        public Manage()
        {
            this.x = 10;
        }

        public Manage(int a)
        {
            this.x = a;
        }

        public void DisplayValue()
        {
            Console.WriteLine("the value of x:{0}", x);
        }
    }
}
