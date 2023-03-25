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
            CustomLinkedList list = new CustomLinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
           list.RemoveFirstNode();
            list.Display();
            list.RemoveLastNode();
            list.Display();
        }
    }
}
