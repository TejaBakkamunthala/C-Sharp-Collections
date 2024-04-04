using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionss
{
    internal class Stack1
    {

        public void Stack11()
        {
            Stack stk = new Stack();

            stk.Push("abc");
            stk.Push("def");
            stk.Push("ghi");
            stk.Push("ijk");
            stk.Push(123);


            Stack<string> st2 = new Stack<string>();
            st2.Push("add");
            st2.Push("sub");
            st2.Push("mul");
          //  st2.Push(123);


            foreach (var items1 in stk)
            {
                Console.WriteLine(items1 + " ");

            }


            Console.WriteLine();
            Console.WriteLine("Peek "+stk.Peek());


                   
            Console.WriteLine("Pop "+stk.Pop());


            foreach (string items2 in stk)
            {
                Console.WriteLine(items2 + " ");
            }


            Console.WriteLine("Count "+st2.Count);
            Console.WriteLine("  ");
            Console.WriteLine(st2.Contains("ghi"));
        }
    }
}