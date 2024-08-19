using System;
namespace DemoAbstraction
{
    //описва всяка една кола
    public class Car : Vehicle
    {

        //наследени характеристики от Vehicle: brand, model
        //характеристики -> color

        //field
        private string color;

        //property
        public string Color { get; set; }

        //конструктор
        public Car (string brand, string model, string color) : base(brand, model)
        {
            //нов празен обект
            this.Color = color;
        }

        //наследени методи:
        //1. StartEngine -> наследен абстрактен метод -> създадем конкретна имплементация
        //2. DisplayInfo -> наследен метод -> мога да го използвам спокойно
        public override void StartEngine()
        {
            //описваме детайли как точно се стартира двигател на кола
            Console.WriteLine("Starting car engine.....");
        }
    }
}

