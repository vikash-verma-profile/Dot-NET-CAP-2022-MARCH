using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Generic_Collections
    {
        //Generic colelctions

        /*
         * Specify type
         * array size if ot fixed
         * elements can be added/removed at runtime
         */
        static void Main(string[] args)
        {

            Console.WriteLine("================LIST=============");
            List<int> lst = new List<int>() { 1, 2, 3, 4, 5 };
            lst.Add(1);

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================Dictionary=============");
            //key value pair
            Dictionary<int,string> dct=new Dictionary<int,string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            foreach (var item in dct)
            {
                Console.WriteLine(item);
            }
            foreach (KeyValuePair<int,string> item in dct)
            {
                Console.WriteLine(item.Key+"===>"+item.Value);
            }

            //sortedList
            
            Console.WriteLine("===============Sorted List===============");
            SortedList<string,string> sl = new SortedList< string,string>();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");
            foreach (KeyValuePair<string, string> item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);

                //Console.WriteLine(item);
            }

            //Stack
            /*
             * LIFO
             */
            Console.WriteLine("===============Stack===============");
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");
            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===============Queue===============");
            //Queue
            /*
            * FIFO
            */

            Queue<string> q = new Queue<string>();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
