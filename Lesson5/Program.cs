/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lesson5
{
    internal class Program
    {
        *//*static void Main(string[] args)
        {

            //task2();
            //task3();
            task4();
            //task5();


        }
*/

        /*  Task2
     İstifadəçidən 2 int dəyər alın və birinci ədədi ikinciyə bölün. 
     Misal: 16, 5. Nəticə 3 yox, 3,2 olmalıdır.
             *//*

        private static void task2()
        {
            int n1 = checkNum("1st");
            int n2 = checkNum("2nd");
            double d = (double)n1 / n2;
            Console.WriteLine(d);
        }


        *//*Task3 Tip Çevirmelerine aid 5 nümunə yazın*//*
        private static void task3()
        {

            double n1 = 50.676767690349393;
            float m1 = (float)n1;
            Console.WriteLine(m1);
            Console.WriteLine("********************");
            byte n2 = 125;
            int m2 = (int)n2;
            Console.WriteLine(m2);
            Console.WriteLine("********************");
            int n3 = 270;
            byte m3 = (byte)n3;
            Console.WriteLine(m3);
            Console.WriteLine("********************");
            long n4 = 20000000000;
            int m4 = (int)n4;
            Console.WriteLine(m4);
        }

        *//*     Task4
     Ədədlər üzərində operatorlardan istifadə etməklə nümunələr yazın.
     Hər operotara aid 1 nümunə.Fərqli data typle - lardan istifadə edin*//*
        static void task4()
        {

            double n1 = 50.676769393;
            float m1 = 33.234f;
            Console.WriteLine(n1 + m1);
            Console.WriteLine(n1 / m1);
            Console.WriteLine(n1 * m1);
            Console.WriteLine("********************");
            byte n2 = 125;
            int m2 = 7008;
            Console.WriteLine(n2 + m2);
            Console.WriteLine(n2 / m2);
            Console.WriteLine(n2 * m2);
            Console.WriteLine("********************");

            long n4 = 20000000000;
            int m4 = 7556;
            Console.WriteLine(n4 + m4);
            Console.WriteLine(n4 / m4);
            Console.WriteLine(n4 * m4);
            Console.WriteLine("********************");
        }


        static void task5()
        {
            int number1 = 7;
            int number2 = 8;
            int number3 = 9;
            var result = !(number1 <= number2) == (number3 != number3++);
            Console.WriteLine(result);
        }

        static int checkNum(String str)
        {
            int retNum = 0;

            while (true)
            {
                Console.WriteLine("Please enter  " + str + " number: ");
                var userNum = Console.ReadLine();
                var isNum = int.TryParse(userNum, out int outNum);
                if (isNum)
                {
                    retNum = outNum;
                    break;
                }

            }

            return retNum;
        }

    }
}
*/