using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class List_Collection
    {
        public static void List()
        {
            Console.WriteLine("Adding elements : ");
            List<string> list = new List<string>();
            list.Add("Shivani");
            list.Add("Sanjana");
            list.Add("Sejal");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list[2]);     // Sejal
        }
    }
}
