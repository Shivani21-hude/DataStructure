using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Linked list ***");
            CustomLinkedList list = new CustomLinkedList();
            Console.WriteLine("Take 1 from given : \n" +
                " 1) Custom Linked List \n 2) Custom Stack DataSturucture \n 3) Custom Queue dataStructure" +
                "\n 4) Built in Linked List");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.Display();
                    list.RemoveFirstNode();
                    list.Display();
                    list.RemoveLastNode();
                    list.Display();
                    break;

                case 2:
                    Console.WriteLine("\n *** Stack DAtaStructure ***");
                    CustomStack stack = new CustomStack();
                    stack.Push(56);
                    stack.Push(30);
                    stack.Push(70);
                    stack.Display();
                    stack.Pop();
                    stack.Display();
                    stack.Peek();
                    stack.Display();
                    break;

                case 3:
                    Console.WriteLine("\n *** Queue DataStructure ***");
                    Custom_Queue queue = new Custom_Queue();
                    queue.Queue(56);
                    queue.Queue(30);
                    queue.Queue(70);
                    queue.Display();
                    queue.Dequeue();
                    queue.Display();
                    break;

                case 4:
                    List_Collection.List();
                    break;

            }
        }
    }
}
