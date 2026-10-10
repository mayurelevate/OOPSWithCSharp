using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceUsingInterface
{
    abstract class BaseClass : Interface3
    {
        public abstract void Interface3Method(); // dont want to implement so use abstract key word.

        public void BaseClassMethod()
        {
            Console.WriteLine("BaseClass Method");
        }

    }
}
