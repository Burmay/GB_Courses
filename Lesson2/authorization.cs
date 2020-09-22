using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class authorization
    {
        public authorization()
        {
            string log = "pentagon";
            string pass = "code";
            int n = 0;
            while (n != 3)
            {
                n++;
                Console.WriteLine("Введите логин");
                string answer = Console.ReadLine();
                if (log == answer)
                {
                    Console.WriteLine("Введите пароль");
                    answer = Console.ReadLine();
                    if (pass == answer)
                    {
                        Console.WriteLine("Вы в системе");
                        n++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Плохо. Пытайся ещё. Ходов до вызова армии по твоему IP - " + (3 - n) + ".");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Такого пользователя нет, как и вашего мозга. Ходов до вызова армии по твоему IP -" + (3 - n) + ".");
                    continue;
                }

            }
            if (n == 3)
            {
                Console.WriteLine("Допизделся, курчавый. Держись.");
            }

            Console.ReadKey();
        }

    }
}
