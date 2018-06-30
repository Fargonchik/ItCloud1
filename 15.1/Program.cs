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
        }
    }
}
