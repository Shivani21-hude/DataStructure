using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Custom_Queue
    {
        public Node head;
        public void Queue(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                while(temp.next!= null)
                {
                    temp = temp.next;               
                }
                 temp.next=node;
            }
            Console.WriteLine("{0} is inserted into Queue", data);
        }

        public void Display()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = this.head;
                while (temp != null)
                {
                    Console.Write(temp.data+ " ");
                    temp = temp.next;
                }
                
            }
        }

        public void Dequeue()
        {
            Console.WriteLine("\n ==> After removing first node ");
            if (this.head == null)
            {
                Console.WriteLine("queue is empty ");
            }
            this.head = head.next;
            Console.WriteLine("Dequeue means removing 1st element : " +this.head);
        }
        
    }
}
