using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays
            // declaration
            int[] a1 = new int[5];
            
            // initialization and traversal (traversal is start to end)
            // in order to access an element we need an index by for loop
            // use a for loop to initialize
            for(int i=0; i<a1.Length; i++)
            {
                a1[i] = (i * 10) + 1;
            }

            // compiler understandings that the brackets are creating a
            // new array and so the new isn't required to initialize
            int[] a2 = { 1, 2, 3, 4, 5 };

            // traversal
            Console.WriteLine("Print the traversal:");
            foreach(int element in a1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Lists
            // declaration
            // call a constructor () to build the object in this list
            List<int> l = new List<int>();

            // initialization
            l.Add(1);
            l.Add(2);
            l.Add(3);
            foreach(int element in l)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // example of element access (using the variable)
            l[1] = 22;
            Console.WriteLine("Insert 22 into slot l1");
            foreach (int element in l)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // some other methods
            l.Insert(2, 99);
            l.Remove(1);
            l.Sort();
            Console.WriteLine("Insert 2,99; Remove 1, Sort");
            foreach (int element in l)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // traversal
            for(int i=0; i<l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            Console.WriteLine();

            foreach(int element in l)
            {
                Console.WriteLine(element);
            }
        }
    }
}
