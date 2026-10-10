using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    public class Calculation     
    {      
        public class Rectangle : Area
        {
            private double _areaRectangle;

            public double areaRectangle
            {
                get
                {
                    return _areaRectangle;
                }
                set
                {
                    this._areaRectangle = value;
                }
            }


            public void Area(double a, double b)
            {
                if((a ==0 || a < 0) && (b == 0 || b < 0))
                {
                    Console.WriteLine("Enter Values are not valid");
                    return;
                }
                areaRectangle = a * b;

                Console.WriteLine("Area of Rectangle : " + areaRectangle);
            }
        }

        public class Circle : Area
        {
            static double PI = 3.14;
            private double _areaCircle;

            public double areaCircle
            {

                get
                {
                    return _areaCircle;
                }
                set
                {
                    this._areaCircle = value;
                }

            }

            public void Area(double a, double b)
            {
                if(a== 0 || a < 0)
                {
                    Console.WriteLine("Enterd values are not valid");
                    return;
                }

                areaCircle = PI * a * a;
                Console.WriteLine("Area of Circle : " + areaCircle);
            }
        }
    }
}
