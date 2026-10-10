using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal.ISP
{
    internal class Sphere : IShape3D
    {
        public double  Radius { get; set; }
        public double Area()
        {
            Console.WriteLine($"Area of Sphere : {Math.PI * Math.Pow(Radius, 2)}");
            return 4 *  Math.PI * Math.Pow(Radius, 2);
        }

        public double volume()
        {
            Console.WriteLine($"Volume of Sphere : {(4.0 * 3.0) * Math.PI * Math.Pow(Radius, 3) }");
            return (4.0 * 3.0) * Math.PI * Math.Pow(Radius , 3);
        }
    }
}
