using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewTestProgram
{
    class ClsFactorial
    {

        public static int calculateFactorial(int number)
        {
            try
            {
                int value = 0;
                int f = 1;

                if (number == 0)
                {
                    return value = 1;
                }
                else
                {
                    for (int i = 1; i <= number; i++)
                    {
                        f = f * i;
                    }
                }
                return value = f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
