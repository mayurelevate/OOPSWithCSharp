using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal.ISP
{

    //ISP - Interface Segrgation Principle 
    internal interface IShape3D
    {
        double Area();
        double volume();
    }

    internal interface IShape2D
    {
        double Area();
    }
}
