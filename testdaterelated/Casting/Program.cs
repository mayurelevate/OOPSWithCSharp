using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double d = 765.12;


                Console.Beep();


                //Explicit Type Casting

                //int i = Convert.ToInt32(d);

                int i = (int)d;

                Console.WriteLine("Value of i is : " + i);
            }
            catch (Exception ex)
            {
                throw;
            }            
            finally
            {

            }
        }
    }
}
