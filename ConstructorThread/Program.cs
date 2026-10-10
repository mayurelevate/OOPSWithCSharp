using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConstructorThread
{

    //public  delegate  void PrintNumber();

    internal class Program
    {
        static void Main(string[] args)
        {           
            ConstructorThread();

            ThreadStartDelegate();

            ThreadClassAnonymousFunction();

            ThreadUsingLambdaExpression();

            ThreadFunctionWithParameter();

            ParameterizedThreadStart();

            Console.ReadLine();            
        }

        static void DisplayNumber()
        {
            for(int i=0; i<=5;i++)
            {
                Console.WriteLine("Number :" + i);
            }
        }

        public void DisplayNumberWithObject(object max)
        {
            int number = Convert.ToInt32(max);

            for(int i=0; i<=number;i++)
            {
                Console.WriteLine("Number :" + i);
            }
        }


        static void ConstructorThread()
        {
            Console.WriteLine("Constructor Thread Start");

            Thread t1 = new Thread(DisplayNumber)
            {
                Name = "Display Number Thread"
            };

            t1.Start();

            Console.WriteLine("Constructor Thread End");
        }

        static void ThreadStartDelegate()
        {
            Console.WriteLine("Thread Start Delegate - Start");


            ThreadStart threadStart = new ThreadStart(DisplayNumber);

            Thread thread = new Thread(threadStart);
            thread.Start();


            Console.WriteLine("Thread Start Delegate - End");
        }


        static void ThreadClassAnonymousFunction()
        {
            Console.WriteLine("Thread Class Anonymous Function - Start");

            Thread t1 = new Thread(delegate ()
            {
                DisplayNumber();

            });

            t1.Start();


            Console.WriteLine("Thread Class Anonymous Function - Ends");
        }

        static void ThreadUsingLambdaExpression()
        {
            Console.WriteLine("Thread Using Lambda Expression - Start");

            Thread t1 = new Thread(() =>
            {
                DisplayNumber();
            });

            t1.Start();

            Console.WriteLine("Thread Using Lambda Expression - Ends");
        }

        static void ThreadFunctionWithParameter()
        {
            Console.WriteLine("Thread Function With Parameter - Start");

            Program obj = new Program();

            Thread thread = new Thread(obj.DisplayNumberWithObject);

            thread.Start(5);

            Console.WriteLine("Thread Function With Parameter - Ends");
        }

        static void ParameterizedThreadStart()
        {
            Console.WriteLine("Parameterized Thread Start - Start");

            Program program = new Program();

            ParameterizedThreadStart PTSD = new ParameterizedThreadStart(program.DisplayNumberWithObject);

            Thread t1 = new Thread(PTSD);

            t1.Start(10);

            Console.WriteLine("Parameterized Thread Start - End");
        }
    }
}
