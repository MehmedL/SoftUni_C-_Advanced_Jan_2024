using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace StartUp
{
    internal class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            Box<double> myBox = new Box<double>();
            for (int i = 0; i < lines; i++)
            {
                myBox.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            }
            double compareWith = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(myBox.Count(compareWith));
        }
    }
}
