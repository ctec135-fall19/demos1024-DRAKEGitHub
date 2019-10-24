using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration
            Dictionary<string, Student> studentDictionary = new
                Dictionary<string, Student>();

            // initialize the dictionary
            studentDictionary.Add("Bill", new Student("Bill"));
            studentDictionary["Jill"] = new Student("Jill");
            studentDictionary["Jack"] = new Student("Jack");

            // traversal of dictionary can traverse keys or values
            Console.WriteLine("Print based on keys");
            foreach(string key in studentDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            Console.WriteLine("Print based on values");
            foreach (Student s in studentDictionary.Values)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

        }
        

    }
}
