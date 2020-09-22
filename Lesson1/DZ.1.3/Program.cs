using System;

namespace DZ._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            a = a * b / (b = a);
            Console.WriteLine(a + " " + b);
            Console.ReadLine();
        }
    }
}
