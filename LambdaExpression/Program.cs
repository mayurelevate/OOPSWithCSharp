using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Program
    {

        public delegate string GreetingDelegate(string _name);
        static void Main(string[] args)
        {
            //GreetingDelegate greetingDelegate = new GreetingDelegate(Greetings);
            //string output = greetingDelegate("Mayur");

            //Console.WriteLine(output);
            //Console.ReadLine();

            //GreetingDelegate obj = delegate (string name)
            //{
            //    return "Hello " + name + " welcome to Dot Net World.";
            //};

            //string GreetingMessage = obj.Invoke("Mayur");


            GreetingDelegate greetingDelegate = (name) =>
            {
                return "Hello " + name + " This output is from lambda Expression.";
            };

            string GreetingMessage= greetingDelegate("Mayur");
            Console.WriteLine(GreetingMessage);
            Console.ReadLine();
        }

        public static string Greetings(string name)
        {
            return "Hello " + name + " welcome to Dot Net World.";
        }
    }
}
