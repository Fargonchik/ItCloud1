using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    class FictionBook: Book
    {
        private string _areaOfFiction;

        public string AreaOfFiction { get { return _areaOfFiction; } }

        public override void Print()
        {
            Console.WriteLine($"AreaOf={_areaOfFiction},");
            base.Print();
        }

        public FictionBook(string author, string title, int numberOfPages, string AreaOfFiction) :
            base(author, title, numberOfPages)
        {
            _areaOfFiction = AreaOfFiction;


        }

        public FictionBook(string author, string title, int numberOfPages) : base(author, title, numberOfPages)
        {
        }
    }
}
