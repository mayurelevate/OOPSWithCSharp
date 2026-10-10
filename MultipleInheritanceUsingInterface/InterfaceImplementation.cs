using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceUsingInterface
{
    class InterfaceImplementation : Interface1, Interface2
    {
        void Interface1.Show()
        {
            Console.WriteLine("Show Method from Interface1");
        }

        void Interface2.Show()
        {
            Console.WriteLine("Show Method from Interface2");
        }

        void Interface1.Test()
        {
            Console.WriteLine("Test Method from Interface1");
        }

        void Interface2.Test()
        {
            Console.WriteLine("Test Method from Interface2");
        }
    }
}
