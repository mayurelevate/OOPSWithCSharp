using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class JaggedArray
    {
        public void Intjaggedarray()
        {
            //Decalration 1
            int[][] arr = new int[2][];

            //Intitalization 1
            arr[0] = new int[5] { 1, 2, 3, 4, 5 };
            arr[1] = new int[5] { 6, 7, 8, 9, 10 };

            // Declaration 1 and Initilization 2
            int[][] arr1 = {
                            new int[] { 1, 2, 3, 4, 5 },
                            new int[] { 6, 7, 8, 9, 10 }
                           };


            // Read Data From arr
            if (arr.Length > 0)
            {
                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    for (int j = 0; j <= arr[i].Length - 1; j++)
                    {
                        Console.WriteLine(arr[i][j]);

                    }
                }
            }


            // Read Data arr1
            if (arr1.Length>0)
            {
                for(int k=0; k<=arr1.Length-1;k++)
                {
                    for(int n = 0; n <= arr1[k].Length-1;n++)
                    {
                        Console.WriteLine(arr1[k][n]);
                    }
                }
            }



        }

    }
}
