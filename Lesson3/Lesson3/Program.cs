using Lesson3;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

struct Complex
{
    public double re;
    public double im;

    public Complex Plus(Complex x)
    {
        Complex y;
        y.re = re + x.re;
        y.im = im + x.im;
        return y;
    }

    public Complex Minus(Complex x)
    {
        Complex y;
        y.re = re - x.re;
        y.im = im - x.im;
        return y;
    }
    public Complex Multiplication(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }

    public string ToString()
    {
        return re + "+" + im + "i";
    }
}
class Program
{
    static void Main(string[] args)
    {
        static void Menu()
        {
            int x;
            bool flag;
            string choice;
            Console.WriteLine("ДЗ по третьему уроку.\nПеврое задание - найти пример нахождения разности комплексных чисел.\nВторое задание - нахождение суммы введённых чисел.\nТретье задание - вычисления с дробями.\nВведите номер задания для просмотра");
            for(; ; )
            {
                do
                {
                    choice = Console.ReadLine();
                    flag = int.TryParse(choice, out x);
                    if (flag == false) Console.WriteLine("Вы криворучка. Постарайтесь, не кося глазом, прочитать условие ещё раз");
                }
                while (flag == false);
                x = int.Parse(choice);
                if (x > 3 || x < 0) Console.WriteLine("Здания с таким номером нет. Постарайтесь, не кося глазом, прочитать условие ещё раз");
                if (x == 1) Task1();
                if (x == 2) Task2();
                if (x == 3) Task3();
            }


        }

        static void Task1()
        {
        Complex complex1;
        complex1.re = 10;
        complex1.im = 20;
        Complex complex2;
        complex2.re = 5;
        complex2.im = 10;

        Complex result1 = complex1.Plus(complex2);
        Console.WriteLine(result1.ToString());
        Console.ReadKey();
        Complex result2 = complex1.Minus(complex2);
        Console.WriteLine(result2.ToString());
        Console.ReadKey();
        Complex result3 = complex1.Multiplication(complex2);
        Console.WriteLine(result3.ToString());
        Console.ReadKey();
        Console.WriteLine("Конец работы программы. Введите следующий номер задания");
        }
        static void Task2()
        {
            string x0;
            int x;
            int s = 0;
            string str = "0";
            bool flag;
            for (; ; ) 
            { 
                do
                {
                    x0 = Console.ReadLine();
                    flag = int.TryParse(x0, out x);
                    if(flag == false) Console.WriteLine("Вы - мудак. Нажмите правильную кнопку.");
                }
                while (!flag);

                if (x == 0) 
                    break; 
                if (x > 0 && x % 2 == 0) 
                { 
                    s = s + x;
                    str = (str + ", " + x);
                } 
 
            } 
            Console.WriteLine($"Сумма чисел равна {s}\nВы ввели следующий ряд чисел: {str}"); 
            Console.ReadKey();
            Console.WriteLine("Конец работы программы. Введите следующий номер задания");
        }
        static void Task3()
        {
            Point A, B;
            A = new Point();
            B = new Point();
            Console.WriteLine("Введите числитель первого числа");
            Console.WriteLine("Введите знаменатель первого числа");
            Console.WriteLine("Введите числитель второго числа");
            Console.WriteLine("Введите знаменатель второго числа");
        }

        Menu();

    }
}
