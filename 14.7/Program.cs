using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._7
{
    class Massive
    {
        private int[] _massive = new int [10];

        public int MinElementValue
        {
            get
            {
                int result = int.MaxValue;

                foreach (var item in _massive)
                {
                    if (item < result)
                    {
                        result = item;
                    }
                }
                return result;
            }

        }

        public int MaxElementValue
        {
            get
            {
                int result = int.MinValue;
                foreach(int item in _massive)
                {
                    if (item > result)
                    {
                        result = item;
                    }
                }
                return result;
            }
        }

        public void DisplayElements()
        {
            Console.WriteLine("Elements of the array: ");

            foreach (int item in _massive)
            {
                Console.WriteLine(item);
            }


        }

        public Massive()
        {
            var random = new Random();
            for (int i = 0; i < _massive.Length; i++)
            {
                _massive[i] = random.Next(10, 101);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new Massive();
            myClass.DisplayElements();
        }
    }
}
