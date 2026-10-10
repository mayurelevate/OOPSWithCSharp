using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class ArrayWithGivenSum
    {
        public void ArraywithSUM()
        {
            //int[] sum_array = new int[5] { 1, 2, 3, 7, 5 };
            //int total = 12;

            //if(sum_array.Length > 0)
            //{

            //    int Position_from = 0; 
            //    int Position_to = 0;

            //    for(int i=0;i<sum_array.Length;i++)
            //    {
            //        Position_from= i+1;
            //        int find_sum = 0;

            //        for (int j = i; j<sum_array.Length;j++)
            //        {
            //            find_sum = find_sum + sum_array[j];

            //            if (find_sum > total)
            //            {
            //                break;
            //            }

            //            if (find_sum == total)
            //            {
            //                Position_to = j + 1;
            //                Console.Write($"{ Position_from }  {Position_to}");
            //                break;
            //            }
            //        }

            //    }
            //}

            List<int> _arrayList = new List<int>()
            {
                1, 2, 3, 7, 5
            };

            int[] sum_array = _arrayList.ToArray();


            long total = 12;

            if (sum_array.Length > 0)
            {

                int Position_from = 0;
                int Position_to = 0;

                for (int i = 0; i < sum_array.Length; i++)
                {
                        Position_from = i + 1;
                        long find_sum = 0;

                    for (int j = i; j < sum_array.Length; j++)
                    {
                        find_sum = find_sum + sum_array[j];

                        if (find_sum > total)
                        {
                            break;
                        }

                        if (find_sum == total)
                        {
                            Position_to = j + 1;
                            Console.Write($"{Position_from}  {Position_to}");
                            break;
                        }
                    }

                    if (find_sum == total)
                    {
                        break;
                    }


                }
            }
        }
    }
}
