using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackMethodHandler
{
    internal class Program
    {
        public delegate void CallBackMethod(string message);

        static void Main(string[] args)
        {
            Program obj = new Program();
            CallBackMethod del = new CallBackMethod(obj.MessageCallBackMethod);
            DoSomeWork(del);
        }


        public static void DoSomeWork(CallBackMethod del)
        {
            Console.WriteLine("Processing some Task");
            del.Invoke("Called From DoSomework Method");
        }


        public  void MessageCallBackMethod(string message)
        {
            Console.WriteLine($"My Message to World {message.ToString()}");
        }
    }
}
