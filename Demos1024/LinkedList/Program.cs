using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new LinkedListNode of type String and display its
            // properties 
            LinkedListNode<String> lln = new LinkedListNode<string>("orange");
            Console.WriteLine("Print Display Properties");
            DisplayProperties(lln);
            Console.WriteLine();

            // create a linked list of type string
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddLast(lln);
            Console.WriteLine("after adding node to list");
            DisplayProperties(lln);
            Console.WriteLine();

            // add
            ll.AddFirst("red");
            ll.AddLast("Yellow");
            Console.WriteLine("after adding node to list");
            DisplayProperties(lln);
            Console.WriteLine();

            Console.WriteLine("Traversal of Linked List");
            LinkedListNode<string> node = ll.First;
            while (node != null)
            {
                Console.WriteLine("     {0}", node.Value);
                node = node.Next;
            }
            Console.WriteLine();


        }

        
        public static void DisplayProperties(LinkedListNode<string> lln)
        {
            if (lln.List == null)
                Console.WriteLine("     Node is not linked");
            else
                Console.WriteLine("     Node belongs to a linked list with {0} elements", lln.List.Count);

            if (lln.Previous == null)
                Console.WriteLine("     Previous node is null");
            else
                Console.WriteLine("     Value of previous node: {0}", lln.Previous.Value);

            if (lln.Next == null)
                Console.WriteLine("     Next node is null");
            else
                Console.WriteLine("     Value of next node: {0}", lln.Next.Value);
        }

        
    }
}
