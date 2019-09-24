using System;

namespace _1_Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, secondName;
            int age, height, weight;

            Console.WriteLine("Здравствуйте! Для корректной работы прошу вводите только целые числа во время вопросов о возрасте и т.д.\nВведите ваше имя:");
            firstName = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            secondName = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост(см):");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш вес(кг):");
            weight = Convert.ToInt32(Console.ReadLine());
            #region Вывести информацию: а)Используя склеивание
            //Console.WriteLine("\nЗдравствуйте, " + firstName +
            //    " " + secondName +
            //    ", вам " + age +
            //    " лет, ваш рост составляет " +
            //    height + "см, ваш вес равен " +
            //    weight + "кг.\nРады познакомиться с Вами!");
            //Console.ReadKey();
            #endregion
            #region б)используя форматированный вывод
            Console.WriteLine("\nЗдравствуйте, {0} {1}, вам {2} лет, ваш рост составляет {3} см, " +
                "ваш вес равен {4} кг.\nРады познакомиться с Вами!", 
                firstName, secondName, age, height, weight);
            Console.ReadKey();
            #endregion
        }
    }
}
