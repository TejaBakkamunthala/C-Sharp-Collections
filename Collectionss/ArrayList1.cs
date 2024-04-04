using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collectionss
{
    internal class ArrayList1
    {


   public void ArrayList11()
        {
            ArrayList al1=new ArrayList();

            al1.Add(1);
            al1.Add("Hii");
            al1.Add("2.34f");

            for(int i = 0; i < al1.Count; i++)
            {
                Console.Write(al1[i]+" ");
            }

            Console.WriteLine("Capacity "+al1.Capacity);


            foreach (object items1 in al1)
            {
                Console.Write(items1 + "  ");

            }
        }
     

    }

}
