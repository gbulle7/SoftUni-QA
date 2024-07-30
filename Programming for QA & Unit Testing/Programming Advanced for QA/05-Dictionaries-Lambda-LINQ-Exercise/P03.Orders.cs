namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            Dictionary<string, List<double>> map = new Dictionary<string, List<double>>();
            while (product != "buy")
            {
                string[] productData = product.Split();
                string name = productData[0];
                double price = double.Parse(productData[1]);
                double quantity = double.Parse(productData[2]);

                if (!map.ContainsKey(name))
                {
                    map[name] = new List<double>();
                    map[name].Add(0);
                    map[name].Add(0);
                }

                map[name][0] = price;
                map[name][1] += quantity;
                product = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<double>> kvp in map)
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value[0] * kvp.Value[1]):F2}");
            }
        }
    }
}
