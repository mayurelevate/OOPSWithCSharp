using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString_v1
{
    internal class Program
    {
        // Rever entire String..
        static void Main(string[] args)
        {

            string input = "Hello World! My name is Mayur";

            int lenght = input.Length;

            StringBuilder sb = new StringBuilder();


            for(int i= lenght-1; i>=0 ; i--)
            {
                sb.Append(input[i]);
            }

            Console.WriteLine($"Reverse String : {sb.ToString().Trim()}");

        }
    }
}
