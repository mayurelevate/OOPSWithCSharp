using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        private static int Counter = 0;

        //private static Singleton instance = null;

        // private static readonly object Instancelock = new object();

        private static readonly Lazy<Singleton> instance = new
            Lazy<Singleton>(
            ()=> new Singleton()
            );

        public Singleton()
        {
            Counter++;
            Console.WriteLine("Counter Value: = " + Counter);
        }


        public static Singleton GetInstance()
        {
            return instance.Value;
        }


        //public static Singleton GetInstance()
        //{
        //    if (instance == null)
        //    {
        //        lock (Instancelock)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new Singleton();
        //            }
        //        }
        //    } 


        //    return instance;
        //}


        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }



    }
}
