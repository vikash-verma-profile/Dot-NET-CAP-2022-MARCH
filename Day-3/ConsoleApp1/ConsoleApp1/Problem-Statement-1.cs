using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PhotoBook
    {
        protected int numpages;

        public PhotoBook()
        {
            numpages = 16;
        }
        public PhotoBook(int numpages)
        {
            this.numpages = numpages;
        }
        public int GetNumberPages()
        {
            return numpages;
        }
    }
    class BigPhotoBook:PhotoBook
    {
        public BigPhotoBook()
        {
            numpages = 64;
        }
    }
    internal class Problem_Statement_1
    {
        public static void Main()
        {
            PhotoBook myalbum1 = new PhotoBook();
            Console.WriteLine(myalbum1.GetNumberPages());

            PhotoBook myalbum2 = new PhotoBook(24);
            Console.WriteLine(myalbum2.GetNumberPages());

            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook.GetNumberPages());
        }
    }
}
