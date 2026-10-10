using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Manage
    {
        int i;
        static int j;

        public Manage()
        {
            i = 100;
        }

        static Manage()
        {
            j = 100;
        }

        public void Display()
        {
            Console.WriteLine("Value of i: " + i);
            i++;

            Console.WriteLine("Value of j: " + j);
            j++;
        }
    }
}
