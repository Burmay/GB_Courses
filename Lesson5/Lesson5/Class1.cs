using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace Lesson5
{
    public class Class1
    {
        public static string NotRegular()
        {
            string login;
            Console.WriteLine("Введите логин, начинающийся с буквы и имеющий длину от 2-х до 10-ти символов");
            while (true)
            {
                login = Console.ReadLine();
                if (login.Length >= 2 && login.Length <= 8 && char.IsLetter(login[0])) 
                {
                    for (int i = 0; i != login.Length; i++)
                    {
                        if (!Char.IsLetterOrDigit(login[i]) || char.IsWhiteSpace(login[i]))
                        {
                            Console.WriteLine("Недопустимые символы");
                            break;
                        }
                    }
                    return login;

                }
                
                else
                    Console.WriteLine("Вы не умеесте считать");
            }
        }

        public static StringBuilder SB()
        {
            Console.WriteLine("Введите логин, начинающийся с буквы и имеющий длину от 2-х до 10-ти символов");
            while (true)
            {
                StringBuilder login = new StringBuilder(Console.ReadLine());
                if (login.Length >= 2 && login.Length <= 8 && char.IsLetter(login[0]))
                    return login;
                else
                    Console.WriteLine("Вы дурак");
            }

        }

        public MatchCollection Regular()
        {
            string a = Console.ReadLine();
            Regex regex = new Regex(@"^\D{1}\w{1,9}$");
            MatchCollection pass = regex.Matches(a);
            return pass;
        }
    }
}
