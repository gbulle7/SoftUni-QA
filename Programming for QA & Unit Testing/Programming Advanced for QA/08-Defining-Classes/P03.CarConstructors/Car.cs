﻿using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {

            double needFuel = distance * FuelConsumption;
            if (FuelQuantity <= needFuel)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity = FuelQuantity - needFuel;
            }

        }

        public string WhoAmI()
        {
            StringBuilder sbInfoCar = new StringBuilder();

            sbInfoCar.Append("Make: " + Make).Append("\n");
            sbInfoCar.Append("Model: " + Model).Append("\n");
            sbInfoCar.Append("Year: " + Year).Append("\n");
            sbInfoCar.Append($"Fuel: {FuelQuantity:F2}");

            return sbInfoCar.ToString();
        }

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

    }
}