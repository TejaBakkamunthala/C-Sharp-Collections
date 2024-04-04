using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionss
{
    internal class LinkedList1
    {

        public void linkedList11()
        {
            LinkedList<string> ll = new LinkedList<string>();

        ll.AddFirst("Ram");
            ll.AddFirst("Charan");
            ll.AddLast("Teja");
            ll.AddFirst("Akhil");

           foreach(string names in ll)
            {
                Console.WriteLine(names+" ");
            }

           


        }
    }

}
