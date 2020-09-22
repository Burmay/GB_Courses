using System;

namespace Empty
{
    class DZ1
    {
        static string question(string variables)
        {
            Console.WriteLine("Введите " + variables);
            string a = Console.ReadLine();
            return a; 
        }
        static void Main()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 10000);
            string name, surname, age, growth, weight;
            name = question("своё имя");
            surname = question("свою фамилию");
            age = question("свой возраст");
            growth = question("свой рост в см");
            weight = question("свой вес");

            double weightInt = double.Parse(weight);
            double growthInt = double.Parse(growth);
            double index = weightInt * 10000 / (growthInt * growthInt);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetWindowSize(100, 50);
            Console.SetBufferSize(100, 50);
            

            Console.WriteLine("Приветствуем, подопытный № {0}.\nВаше заурядное имя - {1}.\nИндификатор принадлежности к племени, \"Фамилия\" - {2}.\nВремя бессмысленного потребления ресурсов - {3} обращений вокруг Солнца.\nРост - {4} нм.\nСтепень жирности - {5:E}, иначе говоря, жирный.\tКстати, индекс вашей упитанности - {6:F}" , number, name, surname, age, growth, weightInt, index);
            Console.ReadKey();
        }


    }
}