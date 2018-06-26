using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1
{
    class Program
    {
        public class TimeStamp
        {
            protected int timeInSec;

            public int TimeInHours {
                get { return timeInSec / 3600; }
                set { timeInSec = value * 3600; }
            }
        }
        static void Main(string[] args)
        {
            var t = new TimeStamp();
            t.TimeInHours = 2;
            Console.WriteLine($"Time in Hours = {t.TimeInHours}");
        }
    }
}
