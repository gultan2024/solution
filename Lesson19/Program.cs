using System;
using System.Collections.Generic;


namespace Project.Lesson19
{
    internal class Program
    {

     /*   public static void Main(string[] args)
        {




            //   task1();

            //  task2(11,22); task2(11,22,33); task2(11,22,33,45);

            //  task3();
            //  task4();
            task5();
            //  task6();
            // task7();
            // task8();
            // task9();
            // task10();
            //  task11();
            // task12();
            //task13();
        }*/

        static void task1()
        {
            Task1 task1 = new Task1();
            task1.Name = "aaaaaaaaa";
            task1.Surname = "bbbbbbbbbbbb";
            Console.WriteLine(task1.FullName);
        }

        /* Bir hesablama methodu yazın.Bu methoda int tipində dəyərlər əlavə edin və bu dəyərləri daxildə toplayın.
         Bunun üçün method overloadingdən istifadə edin.bir methodunuzda 2 parametr, birində 3 və s.*/


        static int task2(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static int task2(int a, int b, int c)
        {
            int sum = a + b + c;

            return sum;
        }
        static int task2(int a, int b, int c, int d)
        {
            int sum = ((a + b + c) + d);
            return sum;

        }




        /*User classı yaradın.Userin name, surname və age fieldləri olsun.İstifadəçidən ad soyad və yaş daxil etməyini istəyin.
        Userdə password fieldi yaradın və bu field bütün istifadəçilər üçün eyni olsun classı istifadə edərkən dəyişdirilə bilsin.
        Və bununla yeni obyekt yaradın.Bu fieldlərin biri olmasa obyekt yarada bilməsin.
        Sonra User classında bir method yaradın və məlumatları konsola yazdırın.*/

        //   task3() {  /* vaxt qalmadi*/}



        /*Istifadeciden bir array alin. Hemin array de tekrarlanan elementleri capa verin.
         Hansi indexlerde tekrarlanibsa onlarida capa verin */
        static void task4()
        {

            Random rnd = new Random();
            int size = rnd.Next(10, 21);
            int[] arr = new int[size];
           
            Dictionary<int, int> repeatList = new Dictionary<int, int>();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(0, 50);
            }


            for (int i = 0; i < size; i++)
            {
                if (!repeatList.ContainsKey(i))
                {
                    for (int j = i + 1; j < size; j++)
                    {

                        if (arr[i] == arr[j])
                        {

                            if (!repeatList.ContainsKey(i)) repeatList.Add(i, arr[i]);
                            repeatList.Add(j, arr[j]);


                        }
                    }
                }


            }

            foreach (var item in arr)
            {

                Console.Write(item + " ");

            }

            Console.WriteLine();
            Console.WriteLine(" Tekrarlanan elementler!");

            foreach (var item in repeatList)
            {

                Console.WriteLine(" Value: " + item.Value + "    " + " Key: " + item.Key);

            }

        }


        /*Istifadeciden 1 eded alin ve bir array yaradin.Hemin ededin arrayin icinde olub olmadigini yoxlayin*/
        static void task5()
        {

            Random rnd = new Random();
            int size = rnd.Next(10, 21);
            int[] arr = new int[size];



            var str = "";

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(0, 999);
                str = str + arr[i] + " , ";


            }
            Console.WriteLine("array: " + str);


            Console.WriteLine("Ededi daxil edin!");
            if (int.TryParse(Console.ReadLine(), out int num))
            {

                for (int i = 0; i < size; i++)
                {
                    if (num == arr[i])
                    {
                        Console.WriteLine("Eded arrayda movcuddur!");
                    }

                }
            }



        }




        /* Daire  classi yaradin.
        Radiusu 5 olan dairenin uzunlugunu hesablayin.*/
        static void task6()
        {
            /* vaxt qalmadi*/
            //  l=2*p*r
        }

        /* Bir eded daxil edin ve hemin ededin sade olub olmadigini yoxlayin*/
        static void task7()
        {
            /* vaxt qalmadi*/
        }




        /*Animal classi yaradin asagidaki fieldleri ve metodlari olsun
        Name,age,hasOwner,
        Void Eat()
        Void Sleep
        Ve bir nece heyvan tipleri yazaraq metodlarin govdelerini doldurun
        Elave olaraq fieldlere İnkapsulyasiya tetbiq edin*/

        static void task8()
        {
            /* vaxt qalmadi*/

        }



        /* Istifadəçidən 10 ilə 20 arasında bir rəqəm alın.Bir array yaradın və daxil edilən rəqəm sayı qədər arraya random rəqəm daxil edin.
           Daha sonra həmin arrayin içərisindən tək ədədləri ayrı, cüt ədələri ayrı şəkildə,ardıcıllıqla konsola yazdırın.*/
        static void task9()
        {
            Random rnd = new Random();
            int size = rnd.Next(10, 21);
            Console.WriteLine($" 10 ile 20 arasi random eded: {size}");
            int[] arr = new int[size];
            string num = " ";
            string oddNum = " ";
            string evenNum = " ";
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(0, 999);
                num = num + arr[i] + " , ";

                if (arr[i] % 2 == 0)
                {
                    evenNum = evenNum + arr[i] + " , ";
                }
                else
                {
                    oddNum = oddNum + arr[i] + " , ";
                }


            }
            Console.WriteLine($" Array: {num}");
            Console.WriteLine($"Tek ededler: {oddNum}");
            Console.WriteLine($"Cut ededler: {evenNum}");

        }

        /* While ilə dövr yaradın.Hər dövrdə istifadəçidən 2 ədəd istəyin.
       Əgər bu 2 ədədin cəmi 6-ya qalıqsız bölünürsə bu zaman dövrü sonlandırın.Əks halda dövrü təkrarlayın.*/
        static void task10()
        {

            Console.WriteLine(" 2 ededi daxil edin!");
            while (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b))
            {
                var c = (a + b) % 6;

                Console.WriteLine($" Qaliq: {c} ");

                if (!(c == 0))
                {
                    Console.WriteLine(" 2 ededi daxil edin!");
                }
                else
                {
                    break;
                }


            }

        }


        /*    3 rəqəmli ədədin rəqəmləri cəmini tapın*/
        static void task11()
        {
            Random rnd = new Random();
            int num = rnd.Next(100, 999);

            int sum = 0;
            int r = 0;
            Console.WriteLine($"Eded: {num}");

            while (!(num == 0))
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }


            Console.WriteLine($"Cem: {sum}");
        }

        /* Verilmiş 3 ədəddən ən böyük və ən kiçiyini tapın */
        static void task12()
        {
            Console.WriteLine(" 3 ededi daxil edin!");
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < 3; i++)
            {

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    if (a >= max)
                    {
                        max = a;
                    }
                    if (a <= min)
                    {
                        min = a;
                    }
                }

            }
            Console.WriteLine($" Minimum eded: {min}, Maximum eded: {min}");

        }


        /*3 rəqəmli ədədlərdən 7 və 8-ə bölünən ədədlərin cəmini tapın*/

        static void task13()
        {
            int sum = 0;
            for (int i = 100; i < 999; i++)
            {
                if ((i % 7 == 0) && (i % 8 == 0))
                {
                    sum = sum + i;
                    Console.Write(i);
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Cem: {sum}");
        }

    }



    /* Bir class yaradın. Bu classın name və surname propeprtyləri və fullname adlı fieldi olsun.
     Fullname fieldinə qıraqdan əl çatmaq olmasın.siz name və surname əlavə etdikdə fulname ad + soyad olaraq təyin edilsin.*/
    class Task1
    {


        public string Name { get; set; }
        public string Surname
        {
            get;
            set;
        }
        public string FullName
        {
            get
            {
                return Name + " " + Surname;

            }

        }

    }
}

