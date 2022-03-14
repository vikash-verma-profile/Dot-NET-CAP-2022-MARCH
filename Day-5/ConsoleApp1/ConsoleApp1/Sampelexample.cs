using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Books
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int ISBNNo { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }
        public string LoT { get; set; }
        public string Language { get; set; }
        public string Summary { get; set; }
        public int NumberofPages { get; set; }

        public Books()
        {
            Language = "English";
            LoT = "Techincal";
        }
        /// <summary>
        ///  This function will add book details
        /// </summary>
        public void DisplayBooks()
        {
            Console.WriteLine("Books Details are :-");
            Console.WriteLine("BookID : " + BookID);
            Console.WriteLine("Book ISBNNo : " + ISBNNo);
            Console.WriteLine("Book BookName : " + BookName);
            Console.WriteLine("Book Publisher : " + Publisher);
            Console.WriteLine("Book Price : " + Price);
            Console.WriteLine("Book LoT : " + LoT);
            Console.WriteLine("Book Language : " + Language);
            Console.WriteLine("Book Summary : " + Summary);
            Console.WriteLine("Book NumberofPages : " + NumberofPages);
        }
        /// <summary>
        /// this function will print all book details
        /// </summary>
        public void GetBookDetails()
        {
            Console.WriteLine("Please enter BookID");
            BookID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter book Name");
            BookName = Console.ReadLine();
            Console.WriteLine("Please enter book Publisher");
            Publisher = Console.ReadLine();
            Console.WriteLine("Please enter book LoT");
            LoT = Console.ReadLine();
            Console.WriteLine("Please enter book Language");
            Language = Console.ReadLine();
            Console.WriteLine("Please enter book Summary");
            Summary = Console.ReadLine();
            Console.WriteLine("Please enter book NumberofPages");
            NumberofPages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Book ISBNNo");
            ISBNNo = Convert.ToInt32(Console.ReadLine());
        }
        public static List<Books> DeleteStudent(List<Books> _bookList, int BookID)
        {
            List<Books> bookList=new List<Books>();
            foreach (var item in _bookList)
            {
                if (item.BookID != BookID)
                {
                    bookList.Add(item);
                }
            }
            return bookList;
        }

    }
    internal class Sampelexample
    {
        public static void Main()
        {
            List<Books> BookList = new List<Books>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please enter your choice:- \n 1.Create \n 2.Delete \n 3.List \n 4.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var book = new Books();
                        book.GetBookDetails();
                        BookList.Add(book);
                        break;
                    case 2:
                        Console.WriteLine("Please enter bookid that you want to delete");
                        int _bookId = Convert.ToInt32(Console.ReadLine());
                        BookList = Books.DeleteStudent(BookList, _bookId);
                        break;
                    case 3:
                        foreach (var item in BookList)
                        {
                            item.DisplayBooks();
                        }
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
