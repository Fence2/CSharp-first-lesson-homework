using System;

namespace _5_PrintFirstAndSecondNamePlusCity
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, secondName, city;

            Console.WriteLine("Введите ваше имя:");
            firstName = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            secondName = Console.ReadLine();
            Console.WriteLine("Введите город проживания:");
            city = Console.ReadLine();

            #region а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания

            Console.WriteLine($"\nВы {firstName} {secondName}, живёте в городе {city}.");
            Console.ReadKey();

            #endregion
            #region б) Сделайте задание, только вывод организуйте в центре экрана
            /*
            string msg = Convert.ToString($"Вы {firstName} {secondName}, живёте в городе {city}.");

            Console.SetCursorPosition(Console.WindowWidth / 2 - msg.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(msg);
            Console.ReadKey();
            */
            #endregion
            #region в) Сделайте задание б с использованием собственных методов (например, Print(string ms, int x,int y)
            /*
            string msg = Convert.ToString($"Вы {firstName} {secondName}, живёте в городе {city}.");

            Print(msg, 30, 30);
            */
            #endregion
        }
        #region метод для задания "в"
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
        #endregion
    }
}
