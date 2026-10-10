using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray.ArrayRotation
{
    public class LeftRotation
    {

        public void rotateArrayLeft()
        {
            int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 99 };

            int d = 2;
            int p = 1;
            int last;
            int array_length = number.Length;

            while (p <= d)
            {
                last = number[0];

                for (int i = 0; i < number.Length - 1; i++)
                {
                    number[i] = number[i + 1];
                }

                number[array_length - 1] = last;
                p++;
            }


            foreach (int num in number)
            {
                Console.Write($"Values : {num} /n");
            }

        }


        public void rotateArrayRight()
        {
            // Output: 7,6,1,2,3,4,5 

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int p = 1;
            int d = 2;

            while (p <= d)
            {
                int first = numbers[numbers.Length - 1];

                for (int i = numbers.Length - 1; i <= numbers.Length - 1; i--)
                {
                    if (i == 0)
                        break;

                    numbers[i] = numbers[i - 1];
                }

                numbers[0] = first;
                p++;
            }
        }

        public void Exercise1()
        {
            int[] arr_num = new int[] { 1, 2, 3, 4, 5 };

            int p = 1;
            int d = 2;
            int last = 0;

            while (p <= d)
            {
                last = arr_num[0];

                for (int i = 0; i < arr_num.Length - 1; i++)
                {
                    arr_num[i] = arr_num[i + 1];
                }


                arr_num[arr_num.Length - 1] = last;

                p++;
            }

            foreach (int item in arr_num)
            {
                Console.Write($"Values : {item}");
            }
        }


        public void rotateWithTempArrayLeftRotation()
        {
            //output : 3,4,5,6,7,8,9,10,1,2
            int[] num_array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] temp = new int[num_array.Length];

            int d = 2;
            int j = 0;

            for(int i=d;i < num_array.Length;i++)
            {
                temp[j] = num_array[i];
                j++;
            }

            for(int i=0;i<d;i++)
            {
                temp[j] = num_array[i];
                j++;
            }


            for(int i=0;i < num_array.Length;i++)
            {
                num_array[i] = temp[i];
            }

            foreach(int item in num_array)
            {
                Console.Write($" Values : {item} ");
            }
        }


        public void rotateWithTempArrayRightRotation()
        {
            int[] num_array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] temp = new int[num_array.Length];

            int x = 0;
            int j = 0;

            for(int i = num_array.Length - 2;i < num_array.Length;i++)
            {
                temp[j] = num_array[i];
                j++;
            }

            for(int i=0; i< num_array.Length-2;i++)
            {
                temp[j] = num_array[i];
                j++;
            }


            for(int i=0;i<num_array.Length;i++)
            {
                num_array[i] = temp[i];
            }

        }
    }
}
