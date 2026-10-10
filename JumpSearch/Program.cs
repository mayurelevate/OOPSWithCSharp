using System;

namespace JumpSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };

                // no to be search in given array 
                int x = 55;

               int index =  JumpSearch(arr, x);

               Console.Write("Number" + x + "is at index" + index);

            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }


        public static int JumpSearch(int[] arr, int searchno)
        {
            try
            {
                // array size
                  int n = arr.Length;

                // find block size to be jumped
                int step = Convert.ToInt32( Math.Floor(Math.Sqrt(n)));

                // find the block where element is present (if it is present)
                int prev = 0;
                
                while(arr[Math.Min(step,n)-1] < searchno)
                {
                    prev = step;
                    step += Convert.ToInt32(Math.Floor(Math.Sqrt(n)));

                    if (prev > n)
                        return -1;
                }


                // Doing linear search for x block begning with prev
                while(arr[prev] < searchno)
                {
                    prev++;

                    // if we reached next block or end of array elemnt is not present

                   if(prev == Math.Min(step,n))
                    {
                        return -1;
                    }
                }


                //If element is found
                if (arr[prev] == searchno)
                    return prev;

                return -1;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
