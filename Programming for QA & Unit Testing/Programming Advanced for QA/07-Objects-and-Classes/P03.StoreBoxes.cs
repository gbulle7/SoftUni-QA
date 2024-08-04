namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (data != "end")
            {
                string[] boxData = data.Split(" ");
                string serialNumber = boxData[0];
                string itemName = boxData[1];
                int itemQuantity = int.Parse(boxData[2]);
                double itemPrice = double.Parse(boxData[3]);
                double boxPrice = itemQuantity * itemPrice;
                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);
                boxes.Add(box);
                data = Console.ReadLine();
            }

            foreach (Box box in boxes.OrderByDescending(x => x.Price))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.Price:F2}");
            }
        }

        //public class Item(string name, double price)
        //{
        //    public string Name { get; set; } = name;
        //    public double Price { get; set; } = price;
        //}

            public class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Item(string name, double price)
            {
                Name = name;
                Price = price;
            }
        }

        public class Box
        {
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }

            public Box(string serialNumber, Item item, int quantity)
            {
                this.SerialNumber = serialNumber;
                Item = item;
                Quantity = quantity;
                Price = quantity * item.Price;
            }
        }

    }
}
