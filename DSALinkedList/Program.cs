using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DSALinkedList.SimpleLinkedList;

namespace DSALinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkedList slt = new SimpleLinkedList();
            slt.head = new Node(1);
            Node second = new Node(3);
            Node third = new Node(4);

            //load new value in second node and add reference of second node in first node.
            slt.head.next = second;

            //load new value in third node and add reference of second node in second node.
            second.next = third;

            slt.push(2);


            slt.printList();
            Console.ReadLine();
        }
    }
}
