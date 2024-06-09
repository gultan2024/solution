using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Project.Lesson24
{
    public class Program
    {
        static public Dictionary<string, User> userList = null;



        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.startMenu();

        }

        public static bool isValidName(string text)
        {
            return text.All(char.IsLetter) && text.Length > 1 & text.Length < 20;
        }

        public static bool isValidAge(byte age)
        {
            return (!age.Equals(null)) & age > 17;
        }

        public static bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


    }
    class Menu
    {
        public void startMenu()
        {
            Console.WriteLine();
            Console.WriteLine("------------Əsas menyu--------------------");
            Console.WriteLine("Xoş Gəlmisiniz!");
            Console.WriteLine("Davam etmək üçün seçin!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            Console.WriteLine($"1: Qeydiyyat");
            Console.WriteLine($"2: Daxil ol!");

            if (int.TryParse(Console.ReadLine(), out int menuId))
            {
                if (menuId == 1) { regstrationMenu(); }
                else if (menuId == 2)
                {

                    if (Program.userList == null)
                    {
                        Console.WriteLine("Qeydiyyatdan keçin!");
                        startMenu();
                    }
                    else { loginMenu(); }
                }

                else { Console.WriteLine("Seçim düzgün edilməmişdir!"); startMenu(); return; }

            }
            else { Console.WriteLine("Seçim düzgün edilməmişdir!"); startMenu(); return; }

        }


        void regstrationMenu()

        {
            Console.WriteLine();
            Console.WriteLine("----------Qeydiyyat menyu----------------------");
            Console.WriteLine("Davam etmək üçün məlumatları daxil edin!");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();



            Console.WriteLine("Ad: ");
            string name = Console.ReadLine();

            while (!Program.isValidName(name)){
                Console.WriteLine("Daxil edtiyiniz ad yalnışdır!");
                Console.WriteLine("Ad: ");
                name = Console.ReadLine();

            }

            Console.WriteLine("Yaş: ");
            bool isValidAge = byte.TryParse(Console.ReadLine(), out byte age);
            while (!isValidAge || age < 18) {
                Console.WriteLine("Daxil edtiyiniz yaş yalnışdır!");
                Console.WriteLine("Yaş: ");
                isValidAge = byte.TryParse(Console.ReadLine(), out age);

            }




            Console.WriteLine("e-mail: ");
            string email = Console.ReadLine();

            if (Program.userList != null)
            {
                while (Program.userList.ContainsKey(email))
                {
                    Console.WriteLine("Daxil edtiyiniz e-mail sistemdə mövcuddur!");
                    Console.WriteLine("e-mail: ");
                    email = Console.ReadLine();
                }

            }

            while (!Program.isValidEmail(email))
            {
                Console.WriteLine("Daxil edtiyiniz e-mail yalnışdır!");
                Console.WriteLine("e-mail: ");
                email = Console.ReadLine();

            }

            Console.WriteLine("Şifrə: ");
            string password = Console.ReadLine();

            while (password == null || password.Length < 1)
            {
                Console.WriteLine("Daxil edtiyiniz şifrə yalnışdır!");
                Console.WriteLine("Şifrə: ");
                password = Console.ReadLine();

            }


            if (Program.userList == null)
            {
                Program.userList = new Dictionary<string, User>();
            }
            User user = new User();
            user.name = name;
            user.age = age;
            user.password = password;
            user.email = email;


            Program.userList.Add(email, user);
            startMenu();

        }


        public void loginMenu()
        {
            User user = null;
            Console.WriteLine();
            Console.WriteLine("--------Login menyu------------------------");
            Console.WriteLine("Davam etmək üçün mail və şifrəni daxil edin!");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("e-mail: ");
            string email = Console.ReadLine();

            while (!Program.userList.ContainsKey(email))
            {
                Console.WriteLine("Daxil edtiyiniz e-mail yalnışdır!");
                Console.WriteLine("e-mail: ");
                email = Console.ReadLine();

            }
            user = Program.userList[email];

            Console.WriteLine("Şifrə: ");
            string pasword = Console.ReadLine();


            if (user.maxAttemptToLogin == 0)
            {
                Console.WriteLine("Siz blok olunmusunuz!");
                startMenu();

            } else  {
                while (pasword != user.password)
                {

                    user.maxAttemptToLogin -= 1;
                    Console.WriteLine("Daxil edtiyiniz şifrə yalnışdır!");
                    if (user.maxAttemptToLogin == 1)
                    {
                        Console.WriteLine("4-cü dəfə şifrəni yalnış daxil etsəniz blok oluncaqsınız!");
                    }
                    else if (user.maxAttemptToLogin == 0)
                    {
                        Console.WriteLine("Blok olundunuz!");
                        startMenu();
                        return;
                    }

                    Console.WriteLine("Şifrə: ");
                    pasword = Console.ReadLine();
                }
                user.maxAttemptToLogin = 4;

                operationMenu(user);

            }



        }

        public void operationMenu(User user)
        {

            Console.WriteLine();
            Console.WriteLine("--------Əməliyyat menyu------------");
            Console.WriteLine("Davam etdirmək üçün seçin!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            Console.WriteLine("1: Mədaxil");
            Console.WriteLine("2: Məxaric");
            Console.WriteLine("3: Balans");
            Console.WriteLine("4: Kredit");
            Console.WriteLine("5: Çıxış");

            float maxCredit = 3000;
            byte maxCreditMonth = 24;

            bool isValidOperationId = byte.TryParse(Console.ReadLine(), out byte operationID);
            while (!isValidOperationId || !((operationID>0)&&(operationID<6)))
            {
                Console.WriteLine("Seçim düzgün edilməmişdir!");
                isValidOperationId = byte.TryParse(Console.ReadLine(), out operationID);
            }


            
             if (operationID !=5) {
                if (operationID == 1)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Mədaxil");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Məbləği daxil edin!");
                    bool isValidIncome = float.TryParse(Console.ReadLine(), out float income);
                    while (!isValidIncome || income < 0) {
                        Console.WriteLine("Məbləğ düzgün daxil edilməmişdir! ");
                        Console.WriteLine("Məbləği daxil edin!");
                        isValidIncome = float.TryParse(Console.ReadLine(), out income);
                    }
                   
                    user.balance += income;
                }
                else if (operationID == 2)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Məxaric");
                    Console.WriteLine("----------------------");
                    bool isValidExpense = float.TryParse(Console.ReadLine(), out float expense);
                    while (!isValidExpense || expense < 0|| expense > user.balance)
                    {
                        if (!isValidExpense || expense < 0) { Console.WriteLine("Məbləğ düzgün daxil edilməmişdir! "); }
                        if (expense > user.balance) { Console.WriteLine($" Balansdan {user.balance} çox məbləğ seçə bilməzsiniz!"); }
                       
                        isValidExpense = float.TryParse(Console.ReadLine(), out expense);
                    }
     



                    user.balance -= expense;
                }
                else if (operationID == 3)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Balans");
                    Console.WriteLine("----------------------");
                    Console.WriteLine($"{user.balance}");
                }
                else if (operationID == 4)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Kredit");
                    Console.WriteLine("----------------------");

                    Console.WriteLine(" Kredit məbləği limiti: " + maxCredit + ",Kredit müddəti: " + maxCreditMonth);
                    Console.WriteLine("Cari Kredit məbləği: " + user.credit + ",Cari Kredit müddəti: " + user.creditMonth);
                    Console.WriteLine();
                    Console.WriteLine("Kredit məbləğini daxil edin!");

                    bool isValidCredit = float.TryParse(Console.ReadLine(), out float credit);

                    while (!isValidCredit || credit <0 || user.credit + credit > maxCredit)
                    {
                        Console.WriteLine("Kredit məbləği düzgün daxil edilməmişdir! ");
                        if (user.credit + credit > maxCredit) { Console.WriteLine($"{maxCredit} kredit limitindən çox məbləğ seçə bilməzsiniz!"); }
                        Console.WriteLine("Kredit məbləğini daxil edin!");
                        isValidCredit = float.TryParse(Console.ReadLine(), out credit);
                    }



                    Console.WriteLine("Kredit müddətini daxil edin!");
                    bool isValidCreditMonth = byte.TryParse(Console.ReadLine(), out byte creditMonth);
                    while (!isValidCreditMonth || creditMonth < 0|| creditMonth > maxCreditMonth)
                    {
                        Console.WriteLine("Kredit müddəti düzgün daxil edilməmişdir! ");
                        if (creditMonth > maxCreditMonth)
                        { 
                            Console.WriteLine($"{maxCreditMonth} aydan çox kredit müddəti seçə bilməzsiniz!");
                        }
                        Console.WriteLine("Kredit müddətini daxil edin!"); 
                        isValidCreditMonth = byte.TryParse(Console.ReadLine(), out creditMonth);
                    }

                   
                    user.creditMonth = creditMonth;
                    user.credit += credit;
                    user.balance += credit;
                    user.creditMonthlyPayment = (float)user.credit / creditMonth;

                    Console.WriteLine("Cari Kredit məbləği: " + user.credit);
                    Console.WriteLine("Cari kredit məbləğinin müddəti " + user.creditMonth);
                    Console.WriteLine("Cari Kreditin aylıq ödənişi " + user.creditMonthlyPayment);
            
               }
                operationMenu(user);
            }
             if (operationID == 5) { startMenu(); return; }








        }

    }




    public class User
    {

        public byte maxAttemptToLogin = 4;
        public int Id { get; set; }
        public string name { get; set; }
        public byte age { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public User()
        {
        }
        public float balance = 0;
        public float credit = 0;
        public byte creditMonth = 0;
        public float creditMonthlyPayment = 0;



    }

}
