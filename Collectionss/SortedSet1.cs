using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionss
{
    public class SortedSet1
    {
        SortedSet<int> ss1 = new SortedSet<int>();


        public void sortedSet11()
        {
            
           

            ss1.Add(10);
            ss1.Add(20);
            ss1.Add(90);
            ss1.Add(70);
            ss1.Add(60);

         
            foreach (int items1 in ss1)
            {
                Console.Write(items1+" ");
            }

            Console.WriteLine(ss1);


            Console.WriteLine();
            SortedSet<string> ss2 = new SortedSet<string>();

            ss2.Add("def");
            ss2.Add("abc");
            ss2.Add("xyz");
            ss2.Add("ghi");

            foreach(string items2 in ss2)
            {
                Console.Write(items2+" ");
            }

        }
    }
}
