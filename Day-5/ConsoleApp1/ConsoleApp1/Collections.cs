using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Collections
    {
        //Collections

        //these are designed to store,manage and manipulate similar data 
        //add
        //insert
        //find
        //replace
        //copy

        /*
         * Non Generic        Generic
         * ArrayList ---------> List
         * HashTable----------->Dicitionary
         * SortedList---------->SortedList
         * Stack--------------->Stack
         * Queue----------------Queue
         */

        //arraylist
        static void Main(string[] args)
        {
            ArrayList arrayList=new ArrayList();
            string str = "Vikash";
            int x = 7;
            DateTime dateTime = DateTime.Now;
            arrayList.Add(x);
            arrayList.Add(str);
            arrayList.Add(dateTime);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===============Hash  Table===============");
            //HashTable
            //key and value
            //x==>778

            Hashtable ht = new Hashtable();
            ht.Add("ora","oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+"===>"+item.Value);

                //Console.WriteLine(item);
            }


            //sortedList
            /*
             * its a combination of arraylist and hashtable
             * arrange all the items in sorted order
             */

            Console.WriteLine("===============Sorted List===============");
            SortedList sl=new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");
            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);

                //Console.WriteLine(item);
            }

            //Stack
            /*
             * LIFO
             */
            Console.WriteLine("===============Stack===============");
            Stack stk=new Stack();
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

            Queue q = new Queue();
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
