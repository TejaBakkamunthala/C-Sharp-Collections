using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionss
{
    internal class HashTable1
    {

        public void hashTable11()
        {
            Hashtable hs = new Hashtable();
            hs.Add("Java", "Java Developer");
            hs.Add("C ", "C Developer");
            hs.Add("Python ", " Python Developer");
            hs.Add("C# ", "C# Developer ");
            hs.Add("ADO.NET", "ADO.NET Developer");


           

            foreach(DictionaryEntry de in hs)
            {
                Console.WriteLine(de.Key+"   "+de.Value);
            }

        }
    }
}
