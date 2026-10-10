using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    public class arrayReverseStack
    {

        public void reverseArrayByStack()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 9, 10, 11 };

            Stack<int> arrayStack = new Stack<int>();

            foreach(int item in numbers)
            {   
                arrayStack.Push(item);
            }

            for(int i=0;i < numbers.Length;i++)
            {
                numbers[i] = arrayStack.Pop();
            }

            foreach(int num in numbers)
            {
                Console.Write($"Array Reverse Value : {num}");
            }
        }
    }
}
