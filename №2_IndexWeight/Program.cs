using System;

namespace _2_IndexWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            double index, weight, height;

            Console.WriteLine("Введите ваш рост (см):");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес (кг):");
            weight = Convert.ToDouble(Console.ReadLine());
            index = weight / ((height/100) * (height/100));
            #region интерпретация показателей ИМТ(индекса массы тела)
            if (index < 16)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nВыраженный дефицит массы тела");
            }
            else if (index < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nНедостаточная (дефицит) масса тела");
            }
            else if (index < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nНормальная масса тела");
            }
            else if (index < 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nИзбыточная масса тела");
            }
            else if (index < 35)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОжирение первой степени");
            }
            else if (index < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОжирение второй степени");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОжирение третьей степени");
            }
            #endregion
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nВаш результат:\n{0:F} кг/м2", index);
            Console.ReadKey();
        }
    }
}
