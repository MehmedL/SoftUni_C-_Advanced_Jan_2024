using System;
using System.Text;

namespace AutomotiveRepairShop
{
    public class Vehicle
    {
        public string VIN { get; set; }
        public int Mileage { get; set; }
        public string Damage { get; set; }

        public Vehicle(string vin, int mileage, string damage)
        {
            this.Damage = damage;
            this.VIN = vin;
            this.Mileage = mileage;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Damage: {Damage},Vehicle: {VIN} ({Mileage} km)");


            return sb.ToString().Trim();
        }
    }
}
