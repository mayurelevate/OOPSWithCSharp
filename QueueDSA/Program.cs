using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueDSA
{
    internal class Program
    {

        /*
         * Queue is a data structure implemented in the .NET Framework in two ways, the simple queue in System.Collections namespace, 
         * and the queue as the generic data structure in System.Collections.Generic namespace, the working principle of queue 
         * structures is FIFO (first in first out), the first element entered first out.
         * 
         */
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.SimpleQueue();
            program.genericqueue();
        }


        public void SimpleQueue()
        {
            // Creates and initializes a new Queue

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            // Display the properties and values of the Queue.

            Console.WriteLine("myQ");
            Console.WriteLine("\t Count: {0}", myQ.Count);
            Console.Write("\t Values");
            PrintValues(myQ);
            Console.ReadLine();
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach(Object obj in myCollection)
            {
                Console.WriteLine(" {0}",obj);
            }

            Console.WriteLine();
        }


        public void genericqueue()
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("One");
            numbers.Enqueue("Two");
            numbers.Enqueue("Three");
            numbers.Enqueue("Four");
            numbers.Enqueue("Five");


            //foreach(string item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            PrintValues(numbers);

            Console.WriteLine("\n Dequeuing '{0}'", numbers.Dequeue());

            Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());

            Console.WriteLine("Dequeue '{0}'", numbers.Dequeue());

            // Create a copy of the queue, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.

            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            Console.WriteLine("\n Content of the First Copy");

            PrintValues(queueCopy);

            // Create an array twice the size of the queue and copy the
            // elements of the queue, starting at the middle of the
            // array.

            string[] array2 = new string[numbers.Count * 2];

            numbers.CopyTo(array2, numbers.Count);

            // Create a second queue, using the constructor that accepts an
            // IEnumerable(Of T).

            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");

            PrintValues(queueCopy2);

            Console.WriteLine("\n queueCopy.Contains(\"four\") = {0}",
                    queueCopy.Contains("four"));

            queueCopy.Clear();

            Console.WriteLine("\n queueCopy.Count = {0}", queueCopy.Count);

        }
    }
}
