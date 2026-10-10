using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class MultidimentionalArray
    {

        public  void MultiDimArray()
        {

            //Two dimensional Array

            int[,] intarray = new int[,]{{1,2},
                                     {3,4 },
                                     {5,6 },
                                     {7,8 }
                                    };


            // The same array with dimensions 
            // specified 4 row and 2 column.
            int[,] intarray_d = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // A similar array with string elements.
            string[,] str = new string[4, 2] { { "One", "two" }, { "Three", "Four" }, { "Five", "Six" }, { "Seven", "Eight" } };


            //Read Data from 2D array

            if (intarray.Length>0)
            {

                int rank = intarray.Rank;
                int rowCount = intarray.GetLength(0);
                int columnsCount = intarray.GetLength(1);



                for(int i=0;i<=intarray.Length-1;i++)
                {
                    if(i< rowCount)
                    {
                        for (int j = 0; j <= columnsCount-1; j++)
                        {
                            Console.WriteLine("Array of ["+ i +"," + j +"] "  +  intarray[i, j]);
                        }
                    }                    
                }
            }


            //Declearation of 3D array -1

            int[,,] intarray3D = new int[,,] {
                {
                    {1,2,3},
                    {4,5,6},
                    {7,8,9},
                    {10,11,12}
                }
            };

            //Declearation of 3D array - 2

            int[,,] intarray3D2 = new int[2, 2, 3] { { {1,2,3},
                                                      {4,5,6} 
                                                    },
                                                    { {7,8,9},
                                                      {10,11,12} 
                                                    }
                                                   };


            //read 3D Array

            if(intarray3D2.Length >0)
            {
                int rank = intarray3D2.Rank;
                int rowCounts = intarray3D2.GetLength(1);
                int columnsCounts = intarray3D2.GetLength(2);

                for(int i=0;i<=intarray3D2.Length-1;i++)
                {
                    if(i < rowCounts)
                    {
                        for(int j=0;j<= rowCounts-1;j++)
                        {
                            for (int k = 0; k <= columnsCounts - 1; k++)
                            {
                                Console.WriteLine("'" + i + "'" + j + "'" + k +"'");
                                Console.WriteLine(intarray3D2[i, j, k]);
                            }                            
                        }
                    }
                }
            }
    } }
}
