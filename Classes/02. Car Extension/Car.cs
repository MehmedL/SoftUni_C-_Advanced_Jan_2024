using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;

        private int year;

        private string model;

        private double fuelQuantity;

        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { fuelConsumption = value; }
        }


        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { fuelQuantity = value; }
        }


        public string Model
        {
            get { return this.model; }
            set { model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { year = value; }
        }
        public string Make
        {
            get { return this.make; }
            set { make = value; }
        }

        public void Drive (double distance)
        {
            if (this.FuelQuantity - (distance * this.fuelConsumption) > 0)
            {
                this.FuelConsumption -= distance * this.fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Fuel: {this.FuelQuantity:F2}L");

            return sb.ToString().TrimEnd();
        }

    }
}