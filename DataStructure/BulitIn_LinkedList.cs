using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class BulitIn_LinkedList
    {
        public static void List()
        {
            Console.WriteLine("\n Built In ListDemo");
            List<string> list = new List<string>();
            list.Add("Shivani");
            list.Add("Shreya");
            list.Add("Shubham");
            
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(" value at index 2  : " + list[2]);   //Shubham
        }
    }
}
