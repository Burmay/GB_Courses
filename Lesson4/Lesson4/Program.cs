using System;
using System.IO;

namespace Lesson4
{    
    class StaticClass
    {
        public static int Couples(int[] a)
        {
            int s = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if ((a[i - 1] % 3 == 0) ^ (a[i] % 3) == 0)
                    s++;
            }
            return s;
        }
        public static int[] CreateArray()
        {
            int[] a = new int[20000];
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-10000, 10000);
            }
            return a;
        }
        public static int[] Reader()
        {
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\sweety\\Desktop\\122.txt");
                int[] a2 = new int[100];
                string n = sr.ReadLine();

                for (int i = 0; !sr.EndOfStream; i++)
                {
                    a2[i] = Convert.ToInt32(sr.ReadLine());
                }
                sr.Close();
                return a2;
            }

            catch(System.IO.FileNotFoundException)
            {
                Console.WriteLine("Вы долбаёб. Повторите, переименовав файл");
                return null;
            }
            finally
            {
                Console.WriteLine("Всегда на посту");
            }
        }

    }
    class Program 
    {
        struct Account
        {
            public string[] Login;
            public string[] Password;
        }
        public int[] a3 { get; set; }

          public Program()
         {
              a3 = new int[100000];

              for (int i = 0; i < a3.Length; i++)
              {
                  a3[i] = i;
              }
          }
          public static int Sum(int[] a3)
          {
              int sum = 0;
              foreach (int number in a3)
              {
                  sum = sum + number;
              }
              return sum;
          }
            public static void Key()
            {
                StreamReader sr = new StreamReader("C:\\Users\\sweety\\Desktop\\Key.txt");
                Account b = new Account();
                for (int i = 0; !sr.EndOfStream; i++)
                {
                    b.Login[i] = sr.ReadLine();
                    b.Password[i] = sr.ReadLine();
                }
            }
        static void Main(string[] args)
        {



            /*new StaticClass();
            int[] a = StaticClass.CreateArray();
            int s = StaticClass.Couples(a);
            Console.WriteLine(s);
            Console.ReadKey();
            int[] a2 = StaticClass.Reader();
            Console.WriteLine(a2.Length);
            Console.ReadLine();*/
            //int s = Sum(a3);
            Key();
            Console.WriteLine();






        }
    }
}
