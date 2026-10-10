using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal.DIP
{
    internal class Engine :IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine Started");
        }
    }
}
