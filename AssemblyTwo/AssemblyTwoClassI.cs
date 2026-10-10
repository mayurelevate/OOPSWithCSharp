using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyTwo
{
   public class AssemblyTwoClassI : AssemblyOneClassI
    {
        public void Test()
        {
            AssemblyOneClassI instance = new AssemblyOneClassI();
            Console.WriteLine(base.ID);        
        }

    }
}
