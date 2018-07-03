using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{

    public class Book
    {
        private string _author;
        private string _title;
        private int _numberOfPages;

        public string Author { get { return _author; } }
        public string Title { get { return _title; } }
        public int NumberOfPages { get { return _numberOfPages; } }

        public virtual void Print()
        {
            Console.WriteLine($"Author= {_author}, Title={_title}, Number of pages = {_numberOfPages}");

        }

        public Book()
        {
            _author = "unknown";
            _title = "unknown";
            _numberOfPages = 0;
        }

        public Book(string author, string title)
        {
            _author = author;
            _title = title;
        }
        public Book(string author, string title, int numberOfPages)
        {
            _author = author;
            _title = title;
            _numberOfPages = numberOfPages;

        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            library.Add(new Book("Lev Tolsyoj", "Voskresenje", 345));
            library.Add(new TecnicalBook ( "Jeffrey Rihter", "C# Core", 344, ".Net" ));
            library.Add(new FictionBook("J. K. Rowling", "Harry Potter and Cup of Fire", 636, "science fiction"));

            Console.WriteLine("Library.Print(BookType.All)");
            library.Print(BookType.All);
            Console.WriteLine();

            Console.WriteLine("Library.Print(BookType.Technical)");
            library.Print(BookType.Technical);
            Console.WriteLine();

            Console.WriteLine("Library.Print(BookType.Fiction)");
            library.Print(BookType.Fiction);
            Console.WriteLine();
        }
    }
}
