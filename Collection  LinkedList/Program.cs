using System;
using System.Collections.Generic;
namespace Collection__LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> l = new LinkedList<string>();

            l.AddLast("akshay");
            l.AddLast("s");
            l.AddLast("akshay");
            l.AddLast("a");
            l.AddLast("z");
            
            foreach (string item in l)
            {
                Console.Write(" "+item);
            }
      
            Console.WriteLine("Total "+l.Count);

            LinkedList<int> l1 = new LinkedList<int>();

            l1.AddLast(2);
            l1.AddLast(10);
            l1.AddLast(90);
            l1.AddLast(9);
            l1.AddLast(90);

            foreach (int item in l1)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine("Total " + l1.Count);

            // Out put
            /*akshay s akshay a z  Total 5
           2 10 90 9 90            Total 5*/




            LinkedList<string> l2 = new LinkedList<string>();

            l2.AddFirst("akshay");
            l2.AddFirst("s");
            l2.AddFirst("akshay");
            l2.AddFirst("a");
            l2.AddFirst("z");

            foreach (string item in l2)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine("Total " + l2.Count);

            LinkedList<int> l3 = new LinkedList<int>();

            l3.AddFirst(2);
            l3.AddFirst(10);
            l3.AddFirst(90);
            l3.AddFirst(9);
            l3.AddFirst(90);

            foreach (int item in l3)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine("Total " + l3.Count);

            // Out Put 

           /* z a akshay s akshay    Total 5
             90 9 90 10 2     Total 5*/
        }
    }
}
