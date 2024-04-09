using DemosOfSlides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Page 6 Func Example
            DelegateExamples examples = new();

            Func<int, int, int> funcAdd = examples.Add;
            Console.WriteLine(funcAdd(20, 40));
            Console.WriteLine(funcAdd(2, 5));

            //Page 7 Action Example
            DelegateExamples examples2 = new();

            Action<string> funcHello = examples2.DisplayGreeting;
            funcHello("Everyone");
            funcHello("World");

            Action<string> funcHelloStatic = DelegateExamples.DisplayGreetingStatic;
            funcHello("Everyone");
            funcHello("World");

            //Page 8 Example Part 1
            List<Book> books = new List<Book>() {
                new Book("Gullivers Travels", 10M, 1726),
                new Book("War and Peace", 20M, 1869),
                new Book("This is going to hurt", 5M, 2017),
            };

            Console.WriteLine("CHEAP BOOKS V1.0");
            List<Book> cheapBooks = FindCheapBooks(books);
            cheapBooks.ForEach(book => Console.WriteLine($"{book.Title}, {book.Price}"));

            Console.WriteLine("\nRECENT BOOKS V1.0");
            List<Book> recentBooks = FindRecentBooks(books);
            recentBooks.ForEach(book => Console.WriteLine($"{book.Title}, {book.YearPublished}"));

            static List<Book> FindCheapBooks(List<Book> books)
            {
                List<Book> output = new List<Book>();
                foreach (Book book in books)
                {
                    if (book.Price < 15M)
                    {
                        output.Add(book);
                    }
                }
                return output;
            }

            static List<Book> FindRecentBooks(List<Book> books)
            {
                List<Book> output = new List<Book>();
                foreach (Book book in books)
                {
                    if (book.YearPublished > 2000)
                    {
                        output.Add(book);
                    }
                }
                return output;
            }


            //Page 9 Example Part 2
            static List<Book> FindBooks(List<Book> books, Func<Book, bool> func)
            {
                List<Book> output = new List<Book>();
                foreach (Book book in books)
                {
                    if (func(book))
                    {
                        output.Add(book);
                    }
                }
                return output;
            }

            static bool CheapBook(Book b)
            {
                return b.Price < 15M;
            }

            static bool RecentBook(Book b)
            {
                return b.YearPublished > 2000;
            }

            Console.WriteLine("\nCHEAP BOOKS V2.0");
            List<Book> cheapBooks2 = FindBooks(books, CheapBook);
            cheapBooks2.ForEach(book => Console.WriteLine($"{book.Title}, {book.Price}"));

            Console.WriteLine("\nRECENT BOOKS V2.0");
            List<Book> recentBooks2 = FindBooks(books, CheapBook);
            recentBooks2.ForEach(book => Console.WriteLine($"{book.Title}, {book.Price}"));

            //Page 11 Example as Lambda
            Func<int, int, int> lamdaAdd = (x, y) => x + y; ;
            Console.WriteLine(lamdaAdd(20, 40));
            Console.WriteLine(lamdaAdd(2, 5));

            // Page 12 Action Example as Lambda
            Action<string> lambdaGreet1 =(string name) => Console.WriteLine($"Greetings {name}");
            lambdaGreet1("Everyone");

            Action<string> lambdaGreet2 = (string name) => Console.WriteLine($"Hello {name}");
            lambdaGreet2("World");



            //Page 13 Example Part 3
            Console.WriteLine("\nCHEAP BOOKS V3.0");
            List<Book> cheapBooks3 = FindBooks(books, b => b.Price < 15M);
            cheapBooks3.ForEach(book => Console.WriteLine($"{book.Title}, {book.Price}"));

            Console.WriteLine("\nRECENT BOOKS V3.0");
            List<Book> recentBooks3 = FindBooks(books, b => b.YearPublished > 2000);
            recentBooks3.ForEach(book => Console.WriteLine($"{book.Title}, {book.YearPublished}"));

            //Page 14 The Predicate Delegate
            Predicate<int> oldEnough = a => a >= 21;

            Console.WriteLine(oldEnough(22));
            Console.WriteLine(oldEnough(18));

            Predicate<Book> isCheapBook = b => b.Price <= 5M;

            Book book = books[2];
            string isCheap = isCheapBook(book) ? "is" : "is not";
            Console.WriteLine($"{book.Title} {isCheap} a cheap book");


            //Page 15 Delegate/Lambda Examples
            //Arrays and Lists have many methods that use a Predicate delegate
            //Finduses a Predicate delegate
            Book? recentBook = books.Find(book => book.YearPublished >= 2015);
            if(recentBook != null )
            {
                Console.WriteLine(recentBook.Title);
            }

            //FindAll uses a Predicate delegate
            List<Book> startsWithW = books.FindAll(book => book.Title.StartsWith('W'));
            //Foreach uses an Action delegate
            startsWithW.ForEach(book => Console.WriteLine(book.Title));

            //Average uses a Func<T, decimal> delegate
            decimal averagePrice = books.Average(b => b.Price);
            Console.WriteLine(averagePrice);
        }
    }
}