using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Collectionss
{
    internal class List1
    {


        List<int> l1=new List<int>();


        public void list11()
        {
            l1.Add(1);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l1.Add(5);
            l1.Add(6);


            int Total11 = l1.Sum(x => x);
            Console.WriteLine("Total " + Total11);


            int total111 = l1.Sum(x => x );
            Console.WriteLine("Total " + total111);


            foreach (int items in l1)
            {
                Console.Write(items+" ");

            }
            int sum = 0;

            for(int i = 0; i < l1.Count; i++)
            {
                sum = sum + l1[i];


            }
            Console.WriteLine();
            Console.WriteLine(sum);


            List<String> str = new List<string>();
            str.Add("Teja");
            str.Add("SAI");
            str.Add("Bridge Labz");
            

            for(int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");

            }

            Console.WriteLine();
            foreach(string items1 in str)
            
            {
                Console.Write(items1+" ");

            }


           // Console.WriteLine( l1.Capacity());

          

           l1.Remove(1);
            Console.WriteLine();

            for(int i=0;i< l1.Count; i++)
            {
                Console.Write(l1[i]+" ");

            }

           bool b1= l1.Contains(2);
            Console.WriteLine(b1);

            Console.WriteLine( l1.Contains(3));


            int cou=l1.Count;
            Console.WriteLine("Count "+cou);

            Console.WriteLine(l1.Equals(2));
            Console.WriteLine(l1.Equals(l1));


           int max= l1.Max();
            Console.WriteLine("Max Element "+max);

            int min=l1.Min();
            Console.WriteLine("Min Element"+min);

            l1.Reverse();
            for(int i=0;i< l1.Count; i++)
            {
                Console.Write( l1[i]+" ");
            }


            Console.WriteLine();

            Console.WriteLine( l1.GetRange(0, l1.Count));

           int Total= l1.Sum(x => x);
            Console.WriteLine("Total "+Total);

            
            int total1=l1.Sum(x => x+x);
            Console.WriteLine("Total "+total1);


            List<int> li=new List<int>();
            l1.Add(10);
            l1.Add(20);
            l1.Add(30);
            l1.Add(40);

            foreach( int i in li)
            {
                Console.Write(i+" ");
            }



        }



       

            


    }
}
