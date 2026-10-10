using System;

namespace BinarySearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int[] myarr = { 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1 };

                //Array.Sort(myarr);

                //DefaultbinarySearch();

                ExerciseOne.ExerciseOneCode();

            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }


        public static void DefaultbinarySearch()
        {
            try
            {
                int[] arr = { 2, 3, 4, 10, 40 };
                int n = arr.Length;
                int x = 10;
                int result = BinarySearch(arr, x);

                if (result == -1)
                    Console.WriteLine("Element not present");
                else
                    Console.WriteLine("Element found at index " + result);

            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        private static int BinarySearch(int[] arr, int x)
        {
            try
            {
                int l = 0, r = arr.Length - 1;

                while(l <= r)
                {
                    int m = l + (r - l) / 2;

                    if(arr[m] == x)
                    {
                        return m;
                    }

                    if(arr[m] < x)
                    {
                        l = m + 1;
                    }
                    else
                    {
                        r = m - 1;
                    }
                }

                return -1;
            }
            catch(Exception ex)
            {
                throw ex.InnerException;
            }
            
        }
    }
}
