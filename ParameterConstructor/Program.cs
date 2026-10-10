using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                employee obj = new employee(1, "Mayur", "Naktode", "Berlin");
                obj.DisplayInfo();

                Console.WriteLine("-----------------------------------------------");

                employee obj1 = new employee(2, "Madhav", "Naktode", "Canada");
                obj1.DisplayInfo();

                Console.ReadKey();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
