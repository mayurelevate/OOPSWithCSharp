using System;
using System.Collections.Generic;
using System.Text;

namespace LinearSearch
{
    public class NewApproach
    {
        public static string SearchNoInArray(int searchitem)
        {
            try
            {
                string output = string.Empty;
                int[] arr = { 1, 2, 3, 4, 5,10 ,12};
                int x = searchitem;
                string result = SearchNo(arr, x);

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }


        private static string SearchNo(int[] arr, int x)
        {
            try
            {

                int left = 0;
                int length = arr.Length;
                int right = length - 1;
                int position = -1;
                string output = string.Empty;



                if(arr.Length > 0)
                {

                    for(left =0; left <= right;)
                    {
                        
                        if(arr[left] == x)
                        {
                            position = left;
                            output =$"Element found in Array at " + (position + 1)  + " Position with " + (left + 1) + " Attempt";
                            break;
                        }


                        if(arr[right] ==  x)
                        {
                            position = right;
                            output =  $"Element found in Array at " + (position + 1) + " Position with " + (length - right) + " Attempt";
                            break;
                        }


                        left++;
                        right--;
                    }


                    if(position == -1)
                    {
                        output = $"Not found in Array with " + left + " Attempt";
                    }

                }

                return output;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
