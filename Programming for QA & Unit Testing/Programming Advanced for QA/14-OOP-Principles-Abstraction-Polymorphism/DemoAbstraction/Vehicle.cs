namespace DemoAbstraction
{
    //oписва всяко едно превозно средство
    //abstract class - не могат да се създават обекти от него
    public abstract class Vehicle
    {
        //характеристики - марка, модел
        //fields
        private string brand;
        private string model;

        //properties
        public string Brand { get; set; }
        public string Model { get; set; }

        //конструктор -> няма да се използва за създаване на обект, но ще се наследява
        public Vehicle(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }

        //действия -> методи

        //запалване на двигателя
        //abstract method - няма имплементация
        public abstract void StartEngine();

        //показва информация за превозното средство
        public void DisplayInfo()
        {
            Console.WriteLine("Brand: " + this.Brand);
            Console.WriteLine("Model: " + this.Model);
        }
    }
}

