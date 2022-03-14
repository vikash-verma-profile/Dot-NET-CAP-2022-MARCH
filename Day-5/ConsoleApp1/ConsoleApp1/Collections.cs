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

            //HashTable
            //key and value
            //x==>778

            Hashtable ht = new Hashtable();
            ht.Add("ora","oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+"===>"+item.Value);

                //Console.WriteLine(item);
            }
        }
    }
}
