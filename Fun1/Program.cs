using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Fun1
{
    class Program
    {
        static public void Main(string[] args)
        {
            Write("Ne lez' ");
            Thread.Sleep(500);
            Write("Blyad' ");
            Thread.Sleep(500);
            Write("Dibil ");
            Thread.Sleep(500);
            Write("Suka ");
            Thread.Sleep(400);
            WriteLine("Ebaniy ");
            Thread.Sleep(1100);
            Write("Ona ");
            Thread.Sleep(300);
            Write("Sozhret ");
            Thread.Sleep(200);
            WriteLine("Tebya!! ");

            WriteLine("||Chtobi Polezt' nazhmite '0'||");
            WriteLine("||Chtobi Ostanovit'sya nazhmite '1'||");

            int a = int.Parse(ReadLine());

            if (a <= 0) ;
            {
                WriteLine("Diblil blyat' ");
                Thread.Sleep(1000);
                WriteLine("Blyyaaaaaaaaaa!!!");
                Thread.Sleep(500);
                WriteLine("Sukaaaaa!!!");
                Thread.Sleep(500);
                WriteLine("blyaaaaaaat'!!");
                Thread.Sleep(800);
                WriteLine("Da kak");
                Thread.Sleep(500);
                WriteLine("Da kak ee ebnut' ? ");
                Thread.Sleep(500);
                WriteLine("Vuaaaaaaa!!!");
                Thread.Sleep(600);
                WriteLine("Palku!!!");
                Thread.Sleep(700);
                WriteLine("Palku davai!!!!");
                Thread.Sleep(900);
                WriteLine("Da ti zaebal!!! ");
                Thread.Sleep(200);
                WriteLine("Blyat' !!!");
                Thread.Sleep(500);
                WriteLine("Kosolapij");
                Thread.Sleep(500);
                WriteLine("Pidor");
                Thread.Sleep(800);
                WriteLine("Kak zhe ti menya zajebal!! ");

            }
        }
    }
}
