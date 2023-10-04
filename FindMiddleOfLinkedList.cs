using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleOfLinkedList
{
     class FindMiddleOfLinkedList
    {
        Node head;

        class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        void printMiddle()
        {
            Node slow_ptr = head;
            Node fast_ptr = head;

            if (head != null)
            {
                while (fast_ptr != null &&
                       fast_ptr.next != null)
                {
                    fast_ptr = fast_ptr.next.next;
                    slow_ptr = slow_ptr.next;
                }
                Console.WriteLine("The middle element is [" +
                                  slow_ptr.data + "] \n");
            }
        }

        public void push(int new_data)
        {

            Node new_node = new Node(new_data);

            new_node.next = head;

            head = new_node;
        }

      public void printList()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.Write(tnode.data + "->");
                tnode = tnode.next;
            }
            Console.WriteLine("NULL");
        }

        //static public void Main()
        //{
        //   FindMiddleOfLinkedList llist = new FindMiddleOfLinkedList();
        //   for (int i = 6; i > 0; --i)
        //    {
        //        llist.push(i);

        //    }
        //   llist.printList();
        //    llist.printMiddle();
        //}
     }
}
