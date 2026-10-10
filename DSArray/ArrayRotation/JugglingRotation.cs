using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray.ArrayRotation
{
    internal class JugglingRotation
    {


        // FOR LEFT ROTATION -- STARTS
        public void JugglingRotationLeft()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int n = arr.Length;
            int d = 2;

            leftRotate(arr, d, n);
            printArray(arr, n);

            // output : 3,4,5,6,1,2
        }


        static int gcd(int a,int b)
        {
            if(b==0)
            {
                return a;
            }
            else
            {
                return gcd(b, a % b);
            }
        }


        public static void leftRotate(int[] arr,int d,int n)
        {
            d = d % n;

            int g_c_d = gcd(d, n);


            for(int i=0; i<g_c_d;i++)
            {
                int temp = arr[i];
                int j = i;

                while(true)
                {
                    int k = j + d;

                    if( k >= n)
                    {
                        k = k - n;
                    }

                    if( k == i)
                    {
                        break;
                    }

                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
        }

        static void printArray(int[] arr,int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        // FOR LEFT ROTATION -- ENDS


        // FOR RIGHT ROTATION NOT WORKING -- STARTS

        //public void JugglingRotationRight()
        //{

        //    int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
        //    int n = arr.Length;
        //    int d = 2;

        //    rightRotate(arr, d, n);
        //}


        //static void rightRotate(int[] arr,int d,int n)
        //{
        //    d = d % n;
        //    int g_c_d = gcd(d, n);

        //    for(int i = (arr.Length - d); i > g_c_d;i--)
        //    {
        //        int temp = arr[i];
        //        int j = i-1;


        //        while(true)
        //        {

        //           int k = j + d;

        //            if(k >=n)
        //            {
        //                k = k - n;
        //            }

        //            if(k==i)
        //            {
        //                break;
        //            }

        //            arr[j] = arr[k];
        //            j = k;
        //        }

        //        arr[j] = temp;
        //    }
        //}
        // FOR RIGHT ROTATION -- ENDS

    }
}
