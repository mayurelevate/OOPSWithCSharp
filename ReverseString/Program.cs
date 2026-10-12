using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{

    // Reverse every word in the string..
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World! My name is Mayur";

            string[] split_string = input.Split(' ');

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < split_string.Length; i++)
            {
                for (int j = split_string[i].Length - 1; j >= 0; j--)
                {
                    sb.Append(split_string[i][j]);
                }

                sb.Append(" ");
            }

            Console.WriteLine($"Original String : {input.ToString()}");
            Console.WriteLine($"Revers String : {sb.ToString().TrimEnd()}");
        }
    }
}
