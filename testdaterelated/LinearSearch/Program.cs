using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {



            //int[] array = { 1, 22, 57, 47, 34, 18, 66 };

            //int[] myarray = new int[array.Length];

            //Array.Sort(array);


            //for (int i = 0; i < array.Length; i++)
            //{
            //    myarray[i] = Convert.ToInt32(array[i].ToString());
            //}




            Console.WriteLine("Enter Any No to search in array");
            int searchno = Convert.ToInt32(Console.ReadLine());

            //string response =  TraditionalApproach.SearchNoInArray(searchno);

            //string response = NewApproach.SearchNoInArray(searchno);

            string response = FirstExercise.SearchNoInArray(searchno);

            Console.WriteLine(response);
            Console.ReadLine();


        }
    }
}
