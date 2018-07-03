using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    class TecnicalBook: Book
    {
        private string _areaOfScience;
        public string AreaOfScience { get { return _areaOfScience; } }

        public override void Print()
        {
            Console.WriteLine($"AreaOf={_areaOfScience},");
            base.Print();
        }

        public TecnicalBook(string author, string title, int numberOfPages, string AreaOfScience) : 
            base(author, title, numberOfPages)
        {
            _areaOfScience = AreaOfScience;


        }
    }
}
