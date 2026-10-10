using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConcept
{
    class Program
    {
        static void Main(string[] args)
        {

            bool Equal = Calculator<string>.AreEqual("10", "20");
        }
    }

    public class Calculator<T>
    {
        public static bool AreEqual(T Value1,T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
