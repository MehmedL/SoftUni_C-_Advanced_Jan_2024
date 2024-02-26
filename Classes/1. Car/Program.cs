using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            car.Make = "Honda";
            Car car2 = new Car();
            car2.Make = "BMW";
            car.Year = 2010;
            car.Model = "Accord";

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
