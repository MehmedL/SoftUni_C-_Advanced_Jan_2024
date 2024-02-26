using System;

namespace CarManufacturer
{
    public class Program
    {
        public  static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Year = 1992;
            car.Model = "MK3";
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive (2000);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
