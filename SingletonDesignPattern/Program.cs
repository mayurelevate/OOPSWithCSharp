using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Below Code is not Single-ton Thread Safe;
            //Singleton fromTeacher = Singleton.GetInstance();
            //fromTeacher.PrintDetails("Teacher Object");

            //Singleton fromStudent = Singleton.GetInstance();
            //fromStudent.PrintDetails("Student Object");

            //Console.WriteLine();

            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
                );

            Console.ReadLine();
        }


        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance();
            fromTeacher.PrintDetails("Teacher Object");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetInstance();
            fromStudent.PrintDetails("Student Object");
        }
    }
}
