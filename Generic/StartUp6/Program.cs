using System;
using System.Globalization;
using StartUp;

namespace StartUp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Questin6();

            //Tuple();
            string[] name = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] bearTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] bankToken = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Threeuple<string,string,string> names =
                new Threeuple<string, string, string>($"{name[0]} {name[1]}", name[2],$"{name[3]} {name[4]}" );

            Threeuple<string, int, bool> bears =
                new Threeuple<string, int, bool>(bearTokens[0], int.Parse(bearTokens[1]), bearTokens[2].ToLower() == "drunk");

            Threeuple<string, double, string> bank =
                new Threeuple<string, double, string>(bankToken[0], double.Parse(bankToken[1], CultureInfo.InvariantCulture), bankToken[2]);

            Console.WriteLine(names);
            Console.WriteLine(bears);
            Console.WriteLine(bank);
        }

        private static void Tuple()
        {
            string[] name = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string, string> names =
                new CustomTuple<string, string>($"{name[0]} {name[1]}", name[2]);

            string[] bearTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string, int> bears =
                new CustomTuple<string, int>(bearTokens[0], int.Parse(bearTokens[1]));

            string[] number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<int, double> numbers =
                new CustomTuple<int, double>(int.Parse(number[0]), double.Parse(number[1], CultureInfo.InvariantCulture));

            Console.WriteLine(names);
            Console.WriteLine(bears);
            Console.WriteLine(numbers);
        }

        private static void Questin6()
        {
            int lines = int.Parse(Console.ReadLine());
            Box<string> myBox = new Box<string>();
            for (int i = 0; i < lines; i++)
            {
                myBox.Add(Console.ReadLine());

            }
            string compareWith = Console.ReadLine();

            Console.WriteLine(myBox.Count(compareWith));
        }
    }
}
