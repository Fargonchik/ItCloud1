using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    public enum BookType
    {
        All,
        Technical,
        Fiction
    }

    class Library
    {
        private List<Book> _books;

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Print(BookType bookType)
        {
            switch (bookType)
            {
                case BookType.All:
                    foreach (var book in _books)
                    {
                        book.Print();
                    }
                    break;

                case BookType.Technical:
                    foreach (var book in _books)
                    {
                        if (book is TecnicalBook)
                        {
                            book.Print();
                        }
                        
                    }
                    break;
                case BookType.Fiction:
                    foreach (var book in _books.Where(c => c is FictionBook))
                    {
                        if (book is FictionBook)
                        {
                            book.Print();
                        }

                    }
                    break;
            }
        }

        public Library()
        {
            _books = new List<Book>();
        }

    }
}
