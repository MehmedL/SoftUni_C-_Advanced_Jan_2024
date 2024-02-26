using System;
using System.Globalization;
using System.Linq;

namespace StartUp9
{
    public class Program
    {
        static void Main()
        {
            string[] name = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] bearTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] bankToken = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Threeuple<string, string, string> names =
                new Threeuple<string, string, string>($"{name[0]} {name[1]}", name[2], $"{name[3]} {name[4]}");

            Threeuple<string, int, bool> bears =
                new Threeuple<string, int, bool>(bearTokens[0], int.Parse(bearTokens[1]), bearTokens[2].ToLower() == "drunk");

            Threeuple<string, double, string> bank =
                new Threeuple<string, double, string>(bankToken[0], double.Parse(bankToken[1], CultureInfo.InvariantCulture), bankToken[2]);

            Console.WriteLine(names);
            Console.WriteLine(bears);
            Console.WriteLine(bank);
        }
    }
}
