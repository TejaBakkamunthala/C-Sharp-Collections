using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionss
{
    internal class Dictionary1
    {

        public void Dictionary11()
        {

            Dictionary<string,string> dic = new Dictionary<string,string>();

            dic.Add("Java", "Java Developer");
            dic.Add("C ", "C Developer");
            dic.Add("Python ", " Python Developer");
            dic.Add("C# ", "C# Developer ");
            dic.Add("ADO.NET", "ADO.NET Developer");


            foreach(string key in dic.Keys)
            {
                Console.WriteLine(key.ToLower()+" ");
            }
            foreach (string value in dic.Values)
            {
                Console.WriteLine(value.ToLower() + " ");
            }


            foreach (KeyValuePair<string,string> kvp in dic)
            {  
                Console.WriteLine(kvp.Key+"                "+kvp.Value);
            }
        }
    }
}
