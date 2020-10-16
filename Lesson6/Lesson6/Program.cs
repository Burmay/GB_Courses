using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
namespace Lesson6
{
    public delegate double Fun(double x);
    public delegate double Func(double x, double a);

    public delegate double F1(double k, double x);

    class Program
    {
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static void Table(Func F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static double MyFunc(double x)
        {
            return x * x * x;
        }
        public static double My(double x, double a)
        {
            return x * x *a;
        }
        public static double Sin(double x, double a)
        {
            x = Math.Sin(x);
            return a * x;
        }
        // *****************************************************************************
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static void SaveFunc(string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// z=z+h;
            }
            bw.Close();
            fs.Close();
        }
        public static void SaveFunc(string fileName,F1 F, double a, double b, double h, double k)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double z = a;
            while (z <= b)
            {
                bw.Write(F(k, z));
                z += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        // *****************************************************************************


        static void Main()
        {
          //SaveFunc("data.bin", -100, 100, 0.5);
          //Console.WriteLine(Load("data.bin"));
          //Console.ReadKey();

            int choice = 0;
            string a;
            string[] b = new string[4];
            int[] c = new int[4];
            bool flag = false;
            Console.WriteLine("Какой тип функции вы хотите вызвать для нахождения минимума?\n1)y = kx\n2)y = k/x\n3)y = kx^\n4)y = log k x");
            while (flag == false)
            {
                a = Console.ReadLine();
                Console.WriteLine("На каком отрезке функции хотите находить минимум? Последоватьельно укажите минимум, максимум и шаг, в целых числах, затем - значениe k");
                for (int i = 0; i != 4; i++)
                {
                    b[i] = Console.ReadLine();
                }
                if (int.TryParse(a, out choice) == true && int.TryParse(b[0], out choice) == true && int.TryParse(b[1], out choice) == true && int.TryParse(b[2], out choice) == true && int.TryParse(b[3], out choice) == true)
                {
                    choice = Convert.ToInt32(a);
                    for (int i = 0; i != 4; i++)
                    {
                        choice = Convert.ToInt32(a);
                        c[i] = Convert.ToInt32(b[i]);
                    }
                    break;
                }
                else
                    Console.WriteLine("Вы мудак, а мы от таких защитились.");
            }
            switch (choice)
            {
                case 1: SaveFunc("data.bin", delegate (double k, double x) { return k * x; }, c[0], c[1], c[2], c[3]);
                Console.WriteLine(Load("data.bin")); break;
                case 2: SaveFunc("data.bin", delegate (double k, double x) { return k / x; }, c[0], c[1], c[2], c[3]);
                    Console.WriteLine(Load("data.bin"));break;
                case 3: SaveFunc("data.bin", delegate (double k, double x) { return k * (x * x); }, c[0], c[1], c[2], c[3]);
                    Console.WriteLine(Load("data.bin"));break;
                case 4: SaveFunc("data.bin", delegate (double k, double x) { return Math.Pow(k, x); }, c[0], c[1], c[2], c[3]);
                    Console.WriteLine(Load("data.bin"));break;
            }

            // *****************************************************************************
            /*Console.WriteLine("Таблица функции MyFunc:");
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически.            
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(Math.Sin, -2, 2);      // Можно передавать уже созданные методы
            Console.WriteLine("Таблица функции x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double x) { return x * x; },2, 3);
            Console.WriteLine("Функция a*x^2");
            Table(new Func(My), 2, 0, 10);
            Console.WriteLine("Таблица функции 2sin(x):");
            Table(Sin, 1.5, -2, 2);*/


            Console.ReadLine();
        }
    }
}