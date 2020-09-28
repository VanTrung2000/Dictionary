using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class BookManagement
    {
        static void Main(string[] args)
        {

            Dictionary<string, Book> bookList = new Dictionary<string, Book>();


            bookList.Add("1", new Book { ISBN = "1", Name = "Đac Nhan Tam", Author = "Nha xuat ban tre" });
            bookList.Add("2", new Book { ISBN = "2", Name = "Ban Dat Gia Bao nhieu", Author = "My Linh" });
            bookList.Add("3", new Book { ISBN = "3", Name = "Doc Vi Bat Ki ai", Author = "DAVID J.LIEBERMAN" });

            Console.WriteLine("Add books to Dictionary");
            PrintValue(bookList);


            bookList["1"] = new Book { ISBN = "1", Name = "Doi Ngan Dung Ngu Dai", Author = "ROBIN SARMA" };

            Console.WriteLine("Edit book with ISBN");
            PrintValue(bookList);


            Console.WriteLine("Search for a specific book with ISBN");
            if (bookList.ContainsKey("2") == false)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Book book = bookList["2"];
                Console.WriteLine("Found this book: " + book.Name);
            }


            bookList.Remove("3");

            Console.WriteLine("Remove book with ISBN");
            PrintValue(bookList);
        }
        public static void PrintValue(Dictionary<string, Book> books)
        {
            foreach (KeyValuePair<string, Book> kvp in books)
            {
                Book book = kvp.Value;

                Console.WriteLine("ISBN: " + book.ISBN + " - " +
                    book.Name + " - " + book.Author);
            }
            Console.WriteLine();
        }
    }
}