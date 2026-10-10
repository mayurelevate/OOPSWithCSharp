using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchApp
{
   public class ExerciseOne
    {
        public static void ExerciseOneCode()
        {
            try
            {
                //int[] arr = { 1, 2, 3, 4, 6 };

                int[] arr = { 1, 3, 4, 5, 6 };
                                                
                int search = 2;
                int output = BinarySearchExerciseOne(arr, search);
                                
                if (output == -1)
                {
                    Console.WriteLine("Element not present");
                }
                else
                {
                    Console.WriteLine("Element found at index " + output);
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }            
        }
        private static int BinarySearchExerciseOne(int[] arr, int x)
        {
            try
            {

                int Left = 0;
                int Right = arr.Length - 1;
                int middle = 0;

                while(Left <= Right)
                {
                    middle = Left + (Right - Left) / 2;


                    if(arr[middle] == x)
                    {
                        return middle;
                    }

                    if(arr[middle] < x)
                    {
                        Left = middle + 1;
                    }

                    if(arr[middle]  > x)
                    {
                        Right = middle - 1;
                    }
                }

                return -1;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }           
        }
    }   
}
