using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class arrayReverseByLoop
    {

        public  void arrayreverseLoop()
        {
            //int[] rollnumber_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] rollnumber_array = { 1, 2, 3, 4, 5, 6, 7 };

            if(rollnumber_array.Length>0)
            {
                int start_index_value = 0;
                int end_index_value = 0;
                int temp=0;

                start_index_value = 0; //always start with 0 because array index first position is by default starts from 0 (zero);

                end_index_value = rollnumber_array.Length-1;

                while(start_index_value < end_index_value)
                {
                    temp = rollnumber_array[start_index_value];

                    rollnumber_array[start_index_value] = rollnumber_array[end_index_value];

                    rollnumber_array[end_index_value] = temp;

                    start_index_value++;
                    end_index_value--;
                }

                foreach(int item in rollnumber_array)
                {
                    Console.Write($"Item Values from reverse array by two pointers : {item}");
                }
            }
        }
    }
}
