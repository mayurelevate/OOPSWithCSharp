using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal.ISP
{
    internal class Circle : IShape2D
    {
        public double Radius { get; set; }
        public double Area()
        {
            Console.WriteLine($"Area of circle : {Math.PI * Math.Pow(Radius, 2)}");
            return Math.PI  * Math.Pow(Radius,2);
        }

    }
}
