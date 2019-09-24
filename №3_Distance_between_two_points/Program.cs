using System;

namespace _3_Distance_between_two_points
{
    class Program
    {
        #region Написать программу, которая подсчитывает расстояние между точками а) в методе Main
        /*
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;
            double r;

            Console.WriteLine("Введите координату x1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату x2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("\nРасстояние между двумя точками:\n{0:F2}", r);
            Console.ReadKey();
        }
        */
        #endregion
        #region б) оформление вычисления расстояния между точками в виде метода
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;

            Console.WriteLine("Введите координату x1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату x2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y2:");
            y2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nРасстояние между двумя точками:\n{0:F2}", distanceBtw2points(x1,y1,x2,y2));
            Console.ReadKey();
        }

        static double distanceBtw2points (int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        #endregion
    }
}
