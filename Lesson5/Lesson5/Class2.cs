using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lesson5
{
    /*
    а) Вывести только те слова сообщения,  которые содержат не более n букв.
    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) Найти самое длинное слово сообщения.
    */
    public static class Message
    {
        public static string[] N()
        {
            Eye eye = new Eye();
            string line = eye.Main();
            string[] a = line.Split();
            string[] b = new string[line.Length];
            for (int i = 0, j = 0; i != a.Length; i++)
            {
                if (a[i].EndsWith(","))
                {
                    a[i] = "";
                }

                if (a[i].Length <= 5)
                {
                    b[j] = a[i];
                    j++;
                }

            }
            
            return b;
        }

        public static string Max()
        {
            Eye eye = new Eye();
            string[] a = eye.Main().Split();
            string max = "";
            for (int i =0; i != a.Length; i++)
            {
                if (a[i].Length > max.Length)
                    max = a[i];
            }
            return max;
        }
        

    }
}
