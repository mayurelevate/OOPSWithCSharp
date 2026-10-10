using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCallbackDemo
{
    public delegate void WorkFinish();
    internal class Program
    {
        static void Main(string[] args)
        {
            //WorkFinish del = new WorkFinish(WorkCompleted);
            //del();
            DoWork(WorkCompleted);
        }


        public static void DoWork(WorkFinish del)
        {
            Console.WriteLine("Working Started");
            Console.WriteLine("Work Completed");
            del();
        }


        public static void WorkCompleted()
        {
            Console.WriteLine(">>> Callback Fired: WorkCompleted() executed.");
            Console.WriteLine("Notification: The main work is done!");
        }
    }
}
