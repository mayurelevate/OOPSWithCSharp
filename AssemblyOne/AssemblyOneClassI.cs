using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        //internal int ID = 1008;

        protected internal int ID = 1008;

    }

    public class AssemblyOneClassII
    {
        public void Test()
        {
            AssemblyOneClassI obj = new AssemblyOneClassI();
            Console.WriteLine(obj.ID);
        }
    }

}
