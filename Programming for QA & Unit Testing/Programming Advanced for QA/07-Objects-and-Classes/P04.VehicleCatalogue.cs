using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (command != "end")
            {
                string[] data = command.Split("/");
                string type = data[0];
                string brand = data[1];
                string model = data[2];
                int value = int.Parse(data[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, value);
                    cars.Add(newCar);
                }
                else
                {
                    Truck newTruck = new Truck(brand, model, value);
                    trucks.Add(newTruck);
                }

                command = Console.ReadLine();
            }

            Catalog catalog = new Catalog() { Cars = cars, Trucks = trucks};

            if (catalog.Cars.Count > 0)
            {
                List<Car> orderedCars = catalog.Cars.OrderBy(car => car.Brand).ToList();

                Console.WriteLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();

                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }

            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }

            public Car(string brand, string model, int horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }
        }

        public class Catalog
        {
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }
    }
}
