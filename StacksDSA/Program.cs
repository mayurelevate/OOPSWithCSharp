using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksDSA
{
    /*
     * Stack is a data structure implemented in the .NET Framework in two ways, 
     * simple stack in System.Collections namespace, and stack as generic data structure in System.Collections.Generic namespace, 
     * the principle of stack structure operation is LIFO (last in first out), the last element entered first out.
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is Simple Stack Example.
            //SimpleStack();

            GenericStack();
        }


        // Simple Stack Starts

        public static void SimpleStack()
        {
            // Create and initializes a new Stack

            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Mayur");
            myStack.Push("!");

            // Display the properties and values of the Stack.
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:{0}", myStack.Count);
            PrintValues(myStack);
            Console.Read();
        }

        public static void PrintValues(IEnumerable collection)
        {
            foreach(Object obj in collection)
            {
                Console.Write(" {0}", obj);
            }

            Console.WriteLine();
        }

        // Simple Stack End

        // Generic Stack Structure Starts


        public static void GenericStack()
        {

            Stack<string> stk_numbers = new Stack<string>();
            stk_numbers.Push("One");
            stk_numbers.Push("Two");
            stk_numbers.Push("Three");
            stk_numbers.Push("Four");
            stk_numbers.Push("Five");

            foreach(string num in stk_numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n First Popping '{0}'", stk_numbers.Pop());

            Console.WriteLine("Peek at next item to destack : {0}", stk_numbers.Peek());

            Console.WriteLine("\n Second Popping '{0}'", stk_numbers.Pop());

            // Create a copy of the stack, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.


            Stack<string> stack2 = new Stack<string>(stk_numbers.ToArray());


            foreach(string item in stack2)
            {
                Console.WriteLine(item);
            }

            // Create an array twice the size of the stack and copy the
            // elements of the stack, starting at the middle of the
            // array.


            string[] str_Array = new string[stk_numbers.Count * 2];
            stk_numbers.CopyTo(str_Array, stk_numbers.Count);


            // Create a second stack, using the constructor that accepts an
            // IEnumerable(Of T).
            Stack<string> stack3 = new Stack<string>(str_Array);

            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");

            foreach(string item in stack3)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
            stack2.Contains("four"));

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);






            Console.Read();
        }


        // Generic Stack Structure Ends

    }
}
