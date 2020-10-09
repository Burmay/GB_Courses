using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
    class Class3
    {
        public bool If()
        {
            bool flag = false;
            Console.WriteLine("Вводите с маленькой буквы");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (b.CompareTo(a) == 0)
            {
                for (int i = 0, j = b.Length; i != a.Length; i++)
                {
                    if (a[i] == b[j - i - 1])
                        flag = true;
                    else
                    {
                        flag = false;
                        break;
                    }
                }
            }
            else
                Console.WriteLine("Строки не равны по длинне");

            return flag;
        }

    }
}
