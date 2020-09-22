using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class greatest
    {
        public greatest()
        {
            string x0, y0, z0;
            Console.WriteLine("Введите первое число");
            x0 = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            y0 = Console.ReadLine();
            Console.WriteLine("Введите третье число");
            z0 = Console.ReadLine();
            double x = double.Parse(x0);
            double y = double.Parse(y0);
            double z = double.Parse(z0);
            if (x >= y && x >= z)
                Console.WriteLine($"Наибольшим является {x}");
            if (y >= x && y >= z)
                Console.WriteLine($"Наибольшим является {y}");
            else
                Console.WriteLine($"Наибольшим является {z}");
            Console.ReadKey();
        }
    }
}
