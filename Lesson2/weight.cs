using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;

namespace Lesson2
{
    class weight
    {
        public weight()
        {
            string r0;
            string v0;
            Console.WriteLine("Введите свой рост");
            r0 = Console.ReadLine();
            Console.WriteLine("Введите свой вес");
            v0 = Console.ReadLine();
            double r = double.Parse(r0);
            double v = double.Parse(v0);

            double i = v * 10000 / (r * r);
            if(i < 18.5)
            {
                Console.WriteLine("Вы - скелет! Немедленно лягте в могилу или наберите " + (((22 * r * r) / 10000) - v) + " кг.");
            }
            if (i >= 18.5 && i < 25)
            {
                Console.WriteLine("Вы совершено обычный и посредственный.");
            }
            if (i >= 25 && i < 30)
            {
                Console.WriteLine("Вы довольно жирный. Отрежьте от пуза " + (v - ((22 * r * r) / 10000)) + " кг.");
            }
            if (i >= 30 && i < 35)
            {
                Console.WriteLine("Жрать - смысл вашей жизни. Измените это и сбростьте " + (v - ((22 * r * r) / 10000)) + " кг.");
            }
            if (i >= 35 && i < 40)
            {
                Console.WriteLine("Вы настолько невероятно жирный, что предстваляете угрозу для психики окружающих. Не знаю, как вы сбросите " + (v - ((22 * r * r) / 10000)) + " кг.");
            }
            if (i >= 40)
            {
                Console.WriteLine("Вы - начинающая чёрная дыра. Ваша биомасса огромна и совершенно бесполезна. Смакуйте это понимние, пока не сбросите " + (v - ((22*r*r)/10000)) + " кг.");
            }
            Console.ReadLine();

        }
    }
}
