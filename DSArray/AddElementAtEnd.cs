using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSArray
{
    internal class AddElementAtEnd
    {
        /// <summary>
        /// Addding new item /element at the end of the list.
        /// </summary>
        public static void AddElementEnd()
        {
            List<int> lst = new List<int> { 1, 2, 3, 4, 5 };

            int new_element = 90;
            int len = lst.Count+1;

            lst.Add(90);

            Console.WriteLine($"After Adding new element in list{string.Join(" ", lst)}");              
        }

        /// <summary>
        /// Delete an Element from the Beginning of an Array
        /// </summary>
        public static void DeleteElementBeginning()
        {
            List<int> arr = new List<int> { 10, 20, 30, 40 };


            arr.RemoveAt(0);

            Console.WriteLine($"After DeleteElementBeginning element in list : {string.Join(" ", arr)}");

        }


        /// <summary>
        /// Delete an Element from the Beginning of an Array Manually
        /// </summary>
        public static void DeleteElementBeginningManually()
        {
            int[] arr = { 10, 20, 30,40 };
            int len = arr.Length;

            for(int i =1; i < len;i++)
            {
                arr[i-1] = arr[i];
            }

            len--;

            for(int i=0; i < len;i++)
            {
                Console.WriteLine($"New Array Element {arr[i]}");
            }

            Console.ReadLine();
        }


        /// <summary>
        /// Delete an Element from a Given Position
        /// </summary>
        public static void DeleteElementFromGivenPosition()
        {
            List<int> arr = new List<int> { 10, 20, 30, 40 };
            int pos = 2;

            Console.WriteLine($"Before Delete an Element from a Given Position {pos} : {string.Join(" ", arr)}");

            arr.RemoveAt(pos-1);

            Console.WriteLine($"Delete an Element from a Given Position {pos} : {string.Join(" ", arr)}");

        }


        /// <summary>
        /// Delete an Element from a Given Position Manually
        /// </summary>
        public static void DeleteElementFromGivenPositionManually()
        {
            int[] arr = { 10, 20, 30, 40 };
            int n = arr.Length;
            int pos = 2;


            for(int i=pos; i<n;i++)
            {
                arr[i-1]= arr[i];
            }

            n = n - 1;

            for(int i=0; i<n;i++)
            {
                Console.WriteLine($"Delete Element From Given Position Manually : {arr[i]}");
            }
        }

        /// <summary>
        /// Delete First Occurrence of Given Element from an Array
        /// </summary>
        public static void DeleteFirstOccurrenceElementArray()
        {
            List<int> arr = new List<int> { 10, 20, 20, 20, 30 };
            int ele = 20;

            arr.Remove(ele);

            Console.WriteLine($"Delete First Occurrence of Given Element from an Array : {string.Join(" ", arr)}");

        }


        /// <summary>
        /// Delete First Occurrence of Given Element from an Array Manually
        /// </summary>
        public static void DeleteFirstOccurrenceElementArrayManually()
        {

            int[] arr = { 10, 20, 20, 20, 30 };
            int n = arr.Length;
            int ele = 20;
            int index = 0;

            Console.WriteLine($"Before : {string.Join(" ", arr)}");

            //for (int i=0; i<n;i++)
            //{
            //    if (arr[i] == ele)
            //    {
            //        index = i+1;
            //        break;
            //    }
            //}

            //for (int i = index; i < n; i++)
            //{
            //    arr[i-1] = arr[i];
            //}

            //n--;
            //for(int i=0; i<n;i++)
            //{
            //    Console.WriteLine($"Delete Element From Given Position Manually : {arr[i]}");
            //}

            bool found = false;
            for (int i = 0; i < n; i++)
            {

                // If the element has been found previously,
                // shift the current element to the left
                if (found)
                {
                    arr[i - 1] = arr[i];
                }

                // check if the current element is equal to
                // the element to be removed
                else if (arr[i] == ele)
                {
                    found = true;
                }
            }

            // If element was found, reduce the size of array
            if (found)
            {
                n--;
            }

            Console.WriteLine("\nArray after deletion");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            //Console.WriteLine($"After Delete First Occurrence of Given Element from an Array Manually : {string.Join(" ", arr)}");
        }
    }
}
