using System;

namespace Keywords
{
    internal class Program
    {
        //collection of homogeneous type of data
        static void Main(string[] args)
        {
            //<data-type> [] <identfier>
            int[] Numbers;
            int[] NumbersList = {1,2,3,89,90,100};

            int length = NumbersList.Length;
            //6
            for (int index = 0; index < length; index++)
            {
                Console.WriteLine(NumbersList[index]);
            }
            Console.WriteLine("================For-Each========================");
            foreach (var item in NumbersList)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
