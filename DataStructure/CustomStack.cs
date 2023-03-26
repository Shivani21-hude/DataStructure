using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class CustomStack
    {
        public Node head;
        public void Push(int data)    //56 30  70 
        {
            Node node = new Node(data);
            if (this.head == null)
                node.next = null;      //56    
            
            else
                node.next = this.head;     //2... next=56  3....next=30    (30 56) 4...next=70
                this.head = node;            // 1...head=56    2...head=30        3... head= 70       
                Console.WriteLine("{0} is inserted into stack " ,data);           
        }
        
        public void Display()
        {
            if (this.head == null)            // head=70
                Console.WriteLine("list is empty");
            else
            {
                Node temp = this.head;       // temp=70
                while(temp!=null)
                {
                    Console.Write(temp.data+" ");         // 70 30 56
                    temp = temp.next;             // 1... 70     2...30    3...56
                }
            }
        }

        public Node Pop()
        {
            Console.WriteLine("\n ==> After removing first node ");
            if (this.head == null)
            {
                return null;
            }
            this.head = head.next;    //head=30   ,  56
            return this.head;          // 30 56 
        }

        public void Peek()
        {
            Console.WriteLine("\n ==> Peek return 1st node value without deleting other nodes ");
            if (this.head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("\n {0} is in the top of the stack ", this.head.data);
        }

    }
}
