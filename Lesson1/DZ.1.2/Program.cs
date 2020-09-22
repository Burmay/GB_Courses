using System;

namespace DZ._1._2
{
    class Program
    {
        static int input(string variables)
        {
            Console.WriteLine("Введите координату " + variables);
            string a = Console.ReadLine();
            int b = (int)Convert.ToInt64(a);
            return b;
        }

        static double distance(int x1, int y1, int x2, int y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        static void Main(string[] args)
        {
            int x1 = input("x первой точки");
            int y1 = input("y первой точки");
            int x2 = input("x второй точки");
            int y2 = input("y второй точки");

            double r = distance(x1, y1, x2, y2);
            Console.WriteLine("Расстояние между точками равно {0:F2}", r);
            Console.ReadKey();
        }
    }
}
