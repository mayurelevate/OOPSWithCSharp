using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal.LSP
{
    internal class Square :Shape
    {

        public double  SideLength { get; set; }
        public override double Area => SideLength * SideLength;
    }
}
