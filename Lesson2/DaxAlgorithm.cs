using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class DaxAlgorithm
    {
        public DaxAlgorithm()
        {
            int z = 1;
            int s;
            int x = 0;
            int sum = 0;
            DateTime start = DateTime.Now;
            for (int i = 1; i != 1000000000; i++, z++)
            {
                int r = z;
                while(r != 0)
                {
                    s = r % 10;
                    r = r / 10;
                    sum = sum + s;
                }
                if ((i % sum) == 0)
                {
                    x++;
                }
                sum = 0;
            }
            Console.WriteLine($"Среди миллиона есть {x} хороших чисел");
            Console.WriteLine("Время выполнения - " + (DateTime.Now-start));
            Console.ReadKey();
        }
    }
}
