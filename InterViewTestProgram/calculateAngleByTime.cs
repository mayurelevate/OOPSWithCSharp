using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewTestProgram
{
    class calculateAngleByTime
    {

        public static double calculateAngle(int hr,int min)
        {
            double degree = 0;

            if(hr < 0 || min < 0)
            {
                return 0;
            }
            else
            {
                double hourInDegree = (hr * 30) + (min * 0.5);
                double minuteInDegree = min * 6;

                double diff = Math.Abs(hourInDegree - minuteInDegree);

                if(diff > 180)
                {
                    diff = 360 - diff;
                }

                degree = diff;
            }
            return degree;
        }
    }
}
