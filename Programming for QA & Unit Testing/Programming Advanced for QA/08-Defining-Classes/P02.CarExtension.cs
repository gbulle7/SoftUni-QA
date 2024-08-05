using System.Text;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        { 
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

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
    }

    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;

            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
