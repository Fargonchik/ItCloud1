using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._4
{
    class Calculator
    {
        private int _calculator;

        public int Value { get; private set; }
       

        public void Inc()
        {
            _calculator = _calculator + 1;
        }
        public void Add(int a)
        {
            _calculator = _calculator + a;
        }
        public void Dec(int a)
        {
            _calculator = _calculator - a;
        }
        public void Mult(int a)
        {
            _calculator = _calculator * a;
        }
        public void Div(int a)
        {
            _calculator = _calculator / a;
        }
        public Calculator(int Value)
        {
            _calculator = Value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator(10);
            calc.Inc();
            Console.WriteLine($"Ic = {calc.Value}");
        }
    }
}
