using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lesson6
{
    internal class Program
    {

       /* static void Main(string[] args)
        {

            task2(6, 6, 6);


        }*/
        /* Verilmiş  a ,b və c tərəflərinə görə üçbucaq qurmağın mümkünlüyünü və həmin üçbucağın bərabəryanlı,
            bərabərtərəfli və ya müxtəliftərəfli olmasını yoxlamalı  */
        static void task2(int a, int b, int c)
        {
            if (((a > Math.Abs(c - b)) & (a < (c + b))) &
                    ((b > Math.Abs(c - a)) & (b < (c + a))) &
               ((c > Math.Abs(a - b)) & (c < (a + b))))
            {
                Console.WriteLine("Ucbucaq qurmaq mumkundur");
                if ((a == b) || (a == c) || (b == c))
                {
                    Console.WriteLine("Ucbucaq beraberyanlidir");

                    if ((a == b) & (b == c))
                    {
                        Console.WriteLine("Ucbucaq berabertereflidir");

                    }
                }
                else
                {
                    Console.WriteLine("Ucbucaq muxteliftereflidir");
                }
            }
            else
            {
                Console.WriteLine("Ucbucaq qurmaq mumkun deyil");
            }



        }
    }
}
