using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passwordLength = 0;
            int lowLetters = -1;
            int highLetters = -1;
            int numbers = -1;
            int spSymbols = -1;
            bool condition = false;
            Console.WriteLine("Добро пожаловать в программу генерации паролей!");
            Console.WriteLine("Для выхода из программы нажмите Q или q, для продолжение нажмите пробел");
            string quitLetter = Console.ReadKey(true).KeyChar.ToString();
            if (quitLetter.Equals("Q")||quitLetter.Equals("q"))
            {
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Пришло время определять правила для пароля");
            }
            /*
             * 1.длина пароля
             * 2.есть ли буквы маленькие
             * 3.есть ли буквы большие
             * 4.есть ли цифры
             * 5.есть ли спецсимволы
             * 6.язык букв
             */
            do
            {
                Console.WriteLine("Укажите длину пароля: (1) - 8 символов, (2) - 16 символов, (3) - 24 символа");
                if (condition)
                {
                    Console.WriteLine("Дурной,да?");
                }
                int.TryParse(Console.ReadLine(),out passwordLength);
                condition = !(passwordLength <= 3 & passwordLength > 0);
            } while (condition);
            condition = false;
            do
            {
                Console.WriteLine("Будет ли пароль содержать буквы в нижнем регистре? (1) - Да, (2) - Нет");
                if (condition)
                {
                    Console.WriteLine("Дурной,да?");
                }
                int.TryParse(Console.ReadLine(), out lowLetters);
                condition = !(lowLetters <= 2 & lowLetters > 0);
            } while (condition);
            condition = false;
            do
            {
                Console.WriteLine("Будет ли пароль содержать буквы в верхнем регистре? (1) - Да, (2) - Нет");
                if (condition)
                {
                    Console.WriteLine("Дурной,да?");
                }
                int.TryParse(Console.ReadLine(), out highLetters);
                condition = !(highLetters <= 2 & highLetters > 0);
            } while (condition);
            condition=false;
            do
            {
                Console.WriteLine("Будет ли пароль содержать цифры? (1) - Да, (2) - Нет");
                if (condition)
                {
                    Console.WriteLine("Дурной,да?");
                }
                int.TryParse(Console.ReadLine(), out numbers);
                condition = !(numbers <= 2 & numbers > 0);
            } while (condition);
            condition = false;
            do
            {
                Console.WriteLine("Будет ли пароль содержать специальные символы? (1) - Да, (2) - Нет");
                if (condition)
                {
                    Console.WriteLine("Дурной,да?");
                }
                int.TryParse(Console.ReadLine(), out spSymbols);
                condition = !(spSymbols <= 2 & spSymbols > 0);
            } while (condition);
            condition = false;
            Console.WriteLine("Длина пароля:"+passwordLength.ToString());
            Console.WriteLine("нижний регистр:"+lowLetters.ToString());
            Console.WriteLine("верхний регистр:"+highLetters.ToString());
            Console.WriteLine("цифры:" + numbers.ToString());
            Console.WriteLine("спец символы:" + spSymbols.ToString());
            StringBuilder password = new StringBuilder(passwordLength*8);
            string smallLetters = "abcdefghijklmnopqrstuvwxyz";
            string bigLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string number = "0123456789";
            string symbols = "!@#$%^&*()-=+|{}[]:;?/.,><~`";
            Random random = new Random();
            for (int i = 0; i < passwordLength * 8; i++)
            {
                int a = random.Next(4);
                if (a == 0)
                {
                    int b = (int)random.Next(smallLetters.Length);
                    password.Append(smallLetters[b]);
                }
                else if (a == 1)
                {
                    int b = (int)random.Next(bigLetters.Length);
                    password.Append(bigLetters[b]);
                }
                else if (a == 2)
                {
                    int b = (int)random.Next(number.Length);
                    password.Append(number[b]);
                }
                else if (a == 3)
                {
                    int b = (int)random.Next(symbols.Length);
                    password.Append(symbols[b]);
                }
            }
            Console.WriteLine(password.ToString());

            //XXXXXXXX

            Console.ReadKey();
        }
    }
}
