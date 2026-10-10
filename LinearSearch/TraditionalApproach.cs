using System;
using System.Collections.Generic;
using System.Text;

namespace LinearSearch
{
    public class TraditionalApproach
    {

        public static string SearchNoInArray(int searchitem)
        {
            try
            {
                string output = string.Empty;
                int[] arr = { 2, 3, 4, 10, 40 };
                int x = searchitem;

                int result = SearchNo(arr, x);

                if (result >= 0)
                {
                    output = $"Search Item Found. The  No. is present at index position: { result}";
                }
                else
                {
                    output = $"Search Item Not Found in list";
                }

                return output;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }


        private static int SearchNo(int[] arr, int x)
        {
            try
            {
                int len = arr.Length;

                if (len > 0)
                {

                    for (int i = 0; i < len; i++)
                    {
                        if (arr[i] == x)
                        {

                            return i;

                        }
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
