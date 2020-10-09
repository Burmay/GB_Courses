using Lesson5;
using System;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        /*string login = Class1.NotRegular();
        Console.ReadKey();

        StringBuilder v = Class1.SB();
        Console.WriteLine(v);
        Console.ReadLine();

        Class1 regular = new Class1();
        MatchCollection max = regular.Regular();
        foreach (Match p in max)
        {
                Console.WriteLine(p);
        }
        Console.WriteLine(max);
        Console.ReadLine();
        
        string[] a = Message.N();
        foreach (string p in a)
        {
            if(p != "" && p != null)
                Console.WriteLine(p);
        }
        Console.ReadLine();
        

        string Max = Message.Max();
        Console.WriteLine(Max);
        Console.ReadLine();

        Class3 class3 = new Class3();
        Console.WriteLine(class3.If());
        Console.ReadLine(); 
        */
        Class4 class4 = new Class4();
        string[] Lowdown = class4.EGE("C:\\Users\\sweety\\Desktop\\LessonS\\LessonS1\\Lesson5\\Lesson5\\Text2.txt");
        foreach(string n in Lowdown)
        {
            Console.WriteLine(n);
        }
        Console.ReadLine();


    }
}
