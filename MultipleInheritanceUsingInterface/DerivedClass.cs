using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceUsingInterface
{
    class DerivedClass : BaseClass
    {
        public override void Interface3Method()
        {
            Console.WriteLine("Abstract override Method Implementation");
        }      

    }
}
