using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSALinkedList
{   
    public class SimpleLinkedList
    {
        //First head of the linked list which is null by default;
        public Node head;

        // this inner class made static so that so its easy to access
        public class Node
        {
            public int data; // to store the data 
            public Node next; // next node value

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public  void printList()
        {
            Node n = head;

            while(n !=null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

        public void push(int newdata)
        {
            Node newNode = new Node(newdata);
            newNode.next = head;
            head = newNode;
        }
    }
}
