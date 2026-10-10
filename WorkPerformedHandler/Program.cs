using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkPerformedHandler
{

    public delegate void WorkPerformedEventHandler(int hours, WorkType wrktyp);
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            int i = 1;

            WorkPerformedEventHandler del1;

            if(i==10)
            {
                del1 = new WorkPerformedEventHandler(Manager_workPerformed);
                del1(i, WorkType.GenerateReports);
            }
            else
            {
                del1 = new WorkPerformedEventHandler(Employee_workPerformed);
                del1(i, WorkType.GenerateReports);
            }

                
           
            Console.ReadLine();
        }

        public static void Manager_workPerformed(int workHours,WorkType wtype)
        {
            Console.WriteLine("Manager received notification: Work Performed - Hours: {0}, Type: {1}", workHours, wtype);
        }

        public static void Employee_workPerformed(int workHours, WorkType wtype)
        {
            Console.WriteLine("Employee received notification: Work Performed - Hours: {0}, Type: {1}", workHours, wtype);
        }
    }


    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}
