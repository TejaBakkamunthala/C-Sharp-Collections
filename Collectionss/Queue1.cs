using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionss
{
    internal class Queue1
    {


        public void queue1()
        {

            Queue q1 = new Queue();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(4);
            q1.Enqueue("hii");
            q1.Enqueue("ram ");
            q1.Dequeue();


            foreach(var items1 in q1)
            {
                Console.Write(items1+" ");
            }

            Queue<string> q2 = new Queue<string>();
            q2.Enqueue("hii ");
            q2.Enqueue("ram");
            q2.Enqueue("how");
            q2.Enqueue("are you");
          // q2.Enqueue(1);
            q2.Dequeue();
             foreach(var items2 in q2)
            {
                Console.Write(items2+" ");
            }


        }


    }
}
