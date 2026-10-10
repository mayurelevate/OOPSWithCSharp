using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal.OCP
{
    // OCP - Open Close Principle 
    public abstract class Shape
    {
        //public ShapeType Type { get; set; } 
        //public double Radius { get; set; }
        //public double Length { get; set; }
        //public double Width { get; set; }
        public abstract double CalculateArea();

    }
}
