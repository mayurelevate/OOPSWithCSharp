using System;
using System.Collections.Generic;
using System.Text;


namespace LinearSearch
{
    public class FirstExercise
    {

        public static string SearchNoInArray(int x)
        {
            try
            {
                string output = string.Empty;
                //int[] Array = { 9, 7, 2, 16, 4 };
                int[] array = { 1, 22, 57, 47, 34, 18, 66 };


                

                
                int searchNo = x;
                output = Search(array, searchNo);
                return output;
            }
            catch (Exception)
            {

                throw;
            }
        }



        private static string Search(int[] array, int searchno)
        {
            string result = string.Empty;

            try
            {
                int left = 0;
                int length = array.Length;
                int right = length-1;                
                int position = 0;

                if(array.Length > 0)
                {
                    for(left =0; left <= right;)
                    {
                        if(array[left] == searchno)
                        {
                            position = left;
                            result = $"K = {searchno} is found in the given array at position {position + 1}.";
                            break;                           
                        }

                        if (array[right] == searchno)
                        {
                            position = right;
                            result = $"K = {searchno} is found in the given array at position {position +1 }.";
                            break;
                        }

                        left++;
                        right--;
                    }

                    if(position == 0)
                    {
                         result = $"K = {searchno} is not  found in the given array.";
                    }
                }
                else
                {
                    result = $"Given Array is Empty.";
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
