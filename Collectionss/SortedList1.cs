using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collectionss
{
    internal class SortedList1
    {

        public void SortedList11()
        {

            SortedList sl1 = new SortedList();

   

            sl1.Add("Java", "Java Developer");
            sl1.Add("C ", "C Developer");
            sl1.Add("Python ", " Python Developer");
            sl1.Add("C# ", "C# Developer ");
            sl1.Add("ADO.NET", "ADO.NET Developer");


            foreach(DictionaryEntry de in sl1)
            {
                Console.WriteLine(de.Key+"   "+de.Value);
            }

           foreach(DictionaryEntry de1 in sl1)
            {
                Console.WriteLine(de1.ToString()+ "  "+de1.Value);
            }

            Console.WriteLine(sl1.GetKey(1));
            Console.WriteLine(sl1.GetKey(3));
            Console.WriteLine(sl1.GetKeyList());



            SortedList<int,string> sl2 = new SortedList<int,string>();



            sl2.Add(1, "Java Developer");
            sl2.Add(2, "C Developer");
            sl2.Add(3, " Python Developer");
            sl2.Add(4 , "C# Developer ");
            sl2.Add(5, "ADO.NET Developer");
            
            foreach(KeyValuePair<int,string> kvp in sl2)
            {
                Console.WriteLine(kvp.Key+"   "+kvp.Value);
            }


        }
    }
}
