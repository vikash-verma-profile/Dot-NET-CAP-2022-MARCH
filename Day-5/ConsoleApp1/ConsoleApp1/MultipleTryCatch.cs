using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class MultipleTryCatch
    {
        //finally :this block will hold the default code 
        //if we have exception or not this finally block will always run
        static void Main(string[] args)
        {
            int[] arr = { 19, 12, 7 };
            try
            {
                //for (int i = 0; i < arr.Length; i++)
                //{
                //    Console.WriteLine(arr[i]/arr[i+1]);
                //}

                //Console.WriteLine(arr[4]);
                // Console.WriteLine(arr[1]/0);
                Console.WriteLine("Hi");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("an execption have occured"+ex.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("an execption have occured" + e.Message);
            }
            catch(ArgumentOutOfRangeException e1)
            {
                Console.WriteLine("an execption have occured" + e1.Message);
            }
            finally
            {
                Console.WriteLine("Hi i am called");
            }
        }
    }
}
