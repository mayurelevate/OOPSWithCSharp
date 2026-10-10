using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethodApp
{
   partial class PartialClass
    {
       partial void PartialMethod();


        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");

            PartialMethod();
            
        }
    }
}
