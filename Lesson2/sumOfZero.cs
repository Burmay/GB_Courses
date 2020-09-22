using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lesson2
{
    class sumOfZero
    {
        public sumOfZero()
        {
            string x0;
            int s = 0;
            for (; ; )
            {
                x0 = Console.ReadLine();
                int x = int.Parse(x0);
                if (x == 0)
                    break;
                if (x > 0 && x % 2 == 0)
                {
                    s = s + x;
                }

            }
            Console.WriteLine($"Сумма чисел равна {s}");
            Console.ReadKey();
        }
    }
}
