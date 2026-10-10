using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            //Creating Thread 
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread 1"
            };


            Thread t2 = new Thread(Method2)
            {
                Name = "Thread 2"
            };

            Thread t3 = new Thread(Method3)
            {
                Name = "Thread 3"
            };

            //Execute Methods:
            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Main Thread Ended");
            Console.ReadLine();
        }

        static void Method1()
        {
            for(int i=0; i <=5;i++)
            {
                Console.WriteLine("Method 1: " + i);
            }
        }

        static void Method2()
        {
            for(int i=0;i <=5;i++)
            {
                Console.WriteLine("Method 2 :" + i);

                if(i==3)
                {
                    Console.WriteLine("performing Some Database Operation - Start");
                    Thread.Sleep(10000);
                    Console.WriteLine("performing Some Database Operation - Completed");
                }
            }
        }

        static void Method3()
        {
            for(int i=0;i<=5;i++)
            {
                Console.WriteLine("Method 3 :" + i);
            }
        }



    }
}
