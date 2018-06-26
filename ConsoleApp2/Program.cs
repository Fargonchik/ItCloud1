using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Calculator()
        {
            Console.WriteLine("Put number A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Put number B");
            int b = int.Parse(Console.ReadLine());
            int result;
            if (b <= 0)
            {
                throw new ArgumentException();
            }

            result = a / b;
            Console.WriteLine("Result = {0}", result);
        }

       
        static void Main(string[] args)
        {
            try
            {
                Calculator();
                   
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Do not put 0 like A or B. Put another numbers that < 0");
            }

        }
    }
}
