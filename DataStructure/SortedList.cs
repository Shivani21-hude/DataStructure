using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class SortedList
    {
        public static void SortArrayList()
        {
            SortedList<int, string> list = new SortedList<int, string>()
            {
                {4,"Shivani" },
                {2,"Rutuja" },
                {1,"Shree" },
                {6,"Suraj" }
            };
            Console.WriteLine("\n ==> Keys In Ascending oeder :");
            foreach(KeyValuePair<int,string> sort in list)
            {
                Console.WriteLine("Key : {0} , Value : {1} ",sort.Key,sort.Value);
            }
            Console.WriteLine("\n ==> Keys in Descending order : ");
            for(int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine("Key : {0} , Value : {1} ", list.ElementAt(i).Key, list.ElementAt(i).Value);
            }

            if (list.Remove(1))      // to remove 
            {
                Console.WriteLine("Removed Successfully");
            }

            list[6] = "Om";    // Update the value

            Console.WriteLine("\n ==> Ater removing and updating : ");

            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine("Key : {0} , Value : {1} ", list.ElementAt(i).Key, list.ElementAt(i).Value);
            }

        }
    }
}
