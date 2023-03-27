using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class BuitIn_Stack
    {
        public static void Stack()
        {
            Console.WriteLine("Adding elements using Push ");
            Stack<int> stack=new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
           
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
            int pop = stack.Pop();
            Console.WriteLine("\n popped element : " +pop );

           
        }
    }
}
