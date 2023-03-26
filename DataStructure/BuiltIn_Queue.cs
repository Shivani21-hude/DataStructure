using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class BuiltIn_Queue
    {
        public static void Queue()
        {
            Console.WriteLine("\n Adding elements :");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Vrutik");
            queue.Enqueue("Sima");
            queue.Enqueue("Vish");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            } 
            string dequeue=queue.Dequeue();
            Console.WriteLine("\n Dequeue element :"+ dequeue);
        }
    }
}
