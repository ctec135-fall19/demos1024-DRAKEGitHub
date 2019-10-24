using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // stacks 
            // declaration 
            Stack<Student> stackOfStudents = new Stack<Student>();

            // intiialize by pushing object onto stack
            stackOfStudents.Push(new Student("Bill"));
            stackOfStudents.Push(new Student("Jill"));
            stackOfStudents.Push(new Student("Jack"));

            // traversal
            Console.WriteLine("Traversal of Stack of Students in LIFO");
            foreach (Student s in stackOfStudents)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(stackOfStudents.Count);
            Console.WriteLine();

            // pops
            Console.WriteLine("Pops");
            int size = stackOfStudents.Count;
            for(int i=0; i<size; i++)
            {
                Console.WriteLine(stackOfStudents.Pop().Name);
            }
            Console.WriteLine(stackOfStudents.Count);
            Console.WriteLine();

            // queue
            Queue<Student> studentQueue = new Queue<Student>();

            // put items in the queue
            studentQueue.Enqueue(new Student("Regina"));
            studentQueue.Enqueue(new Student("Kyle"));
            studentQueue.Enqueue(new Student("Allison"));

            // traversal of queue
            Console.WriteLine("Traversal of Queue with FIFO");
            foreach (Student s in studentQueue)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(stackOfStudents.Count);
            Console.WriteLine();

            size = studentQueue.Count;
            Console.WriteLine("DeQueue of studentQueue");
            for (int i = 0; i < size; i++) 
            {
                Console.WriteLine(studentQueue.Dequeue().Name);
            }
            Console.WriteLine(stackOfStudents.Count);
            Console.WriteLine();
        }
    }
}
