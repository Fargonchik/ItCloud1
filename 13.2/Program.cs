using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    class Program
    {
        

        static void Main(string[] args)
        { 


            Random random = new Random();

            int lenghtOfArray = random.Next(100);

            byte[] byteArray = new byte[lenghtOfArray];

            int count = 0;

            do
            {
                int index = random.Next(lenghtOfArray + 5);
                try
                {
                    byteArray[index] = (byte)random.Next(300);

                }
                catch (ArgumentOutOfRangeException)
                {

                    Console.WriteLine($"{index} out of range");
                }
                catch (IndexOutOfRangeException)
                {

                    Console.WriteLine($"{index} out of range. lenght Of Array = {lenghtOfArray}");
                }
                count++;

            }
            while (count < lenghtOfArray);

            Console.WriteLine($"Count = {count}");
        }
    }
}
