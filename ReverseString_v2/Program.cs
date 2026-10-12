using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "Hello World! My name is Mayur";

            int lenght = input.Length;

            string[] string_split = input.Split(' ');

            StringBuilder sb = new StringBuilder();

            for(int i=0; i< string_split.Length; i++)
            {
                if((i%2)!=0)
                {

                    for(int j= string_split[i].Length-1; j>=0;j--)
                    {
                        sb.Append(string_split[i][j]);
                    }
                }
                else
                {
                    sb.Append(string_split[i]);
                }

                sb.Append(" ");
            }

            Console.WriteLine($"Reverse String : {sb.ToString().Trim()}");
            Console.ReadLine();
        }
    }
}
