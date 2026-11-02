using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class InsertElementInArray
    {
        public static void AddAtBegining()
        {
            List<int> arrayList = new List<int> { 10, 20, 30, 40 } ;

            int element = 50;


            Console.WriteLine($"Array Before Insertation {string.Join(" ",arrayList)}");

            //foreach(int item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            arrayList.Insert(0, element);


            Console.WriteLine($"Array After Insertation { string.Join(" ",arrayList)}");

            //foreach (int item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();

        }


        public static void AddAtBeginingManually()
        {
            int[] arr = { 10, 20, 30, 40, 0 };
            int n = arr.Length -1;
            int element = 50;

            for (int i = n - 1; i >= 0; i--)
            {
                arr[i + 1] = arr[i];
            }

            arr[0] = element;

            Console.WriteLine($"After Insertation: {string.Join(" ", arr)}");
        }

        public static void AddAtBeginingManuallyV1()
        {
            int[] arr = { 10, 20, 30, 40};
            int n = arr.Length - 1;
            int element = 50;

            for (int i = n - 1; i >= 0; i--)
            {
                arr[i + 1] = arr[i];
            }

            arr[0] = element;

            Console.WriteLine($"After Insertation: {string.Join(" ", arr)}");
        }
    }
}
