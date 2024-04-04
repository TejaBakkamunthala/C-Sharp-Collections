using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collectionss
{
    internal class HashSet1
    {

        public void hashSett1()
        {


            HashSet<String> alpha = new HashSet<string>();
            alpha.Add("abc");
            alpha.Add("def");
            alpha.Add("ghi");
            alpha.Add("ijk");
            alpha.Add("abc");
            alpha.Add("ijk");

            //for (int i = 0; i < alpha.Count; i++)
            //{
            //    Console.WriteLine(alpha[i] + " ");
            //}


            foreach (string items in alpha)
            {
                Console.WriteLine(items + " ");

            }


            Console.WriteLine();

            HashSet<string> names = new HashSet<string>() { "c#", ".Net", "java", "python","C#","C#" };

            foreach(string  items1 in names)
            {
                Console.WriteLine(items1 + " ");
            }

            Console.WriteLine();

            names.Add("jdbc");

             bool b1=names.Contains("jdbc");
            Console.WriteLine(b1);


            
            foreach (string items2 in names)
            {
                Console.Write(items2+" ");
            }

            Console.WriteLine();






        }
    }
}
