using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class quantity
    {
        public quantity()
        {
            Console.WriteLine("Введите число");
            string x0 = Console.ReadLine();
            int x = int.Parse(x0);
            int k = 0;
            while(x != 0)
            {
               x = x / 10;
                k++;
            }
            Console.WriteLine($"Количество знаков равно {k}");
            Console.ReadKey();
        }
    }
}
