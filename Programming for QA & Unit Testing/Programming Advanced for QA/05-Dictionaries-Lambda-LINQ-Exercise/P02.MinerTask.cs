namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> map = new Dictionary<string, int>();
            while (resource != "stop")
            {
                if (!map.ContainsKey(resource))
                {
                    map.Add(resource, 0);
                }
                int quantity = int.Parse(Console.ReadLine());
                map[resource] += quantity;
                resource = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> kvp in map)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
