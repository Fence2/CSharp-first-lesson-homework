using System;

namespace _4_switchVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите переменную a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную b:");
            b = Convert.ToInt32(Console.ReadLine());
            #region Написать программу обмена значениями двух переменных а) с использованием третьей переменной
            /*
            int temp = a;
            a = b;
            b = temp;
            */
            #endregion
            #region б) без использования третьей переменной

            b = a + b;
            a = b - a;
            b = b - a;

            #endregion
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.ReadKey();
        }
    }
}
