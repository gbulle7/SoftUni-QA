namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                string command = tokens[0];
                string name = tokens[1];

                if (command == "register")
                {
                    string license = tokens[2];
                    if (parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                        continue;
                    }
                    parking.Add(name, license);
                    Console.WriteLine($"{name} registered {license} successfully");
                }
                else
                {
                    if (!parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        continue;
                    }
                    parking.Remove(name);
                    Console.WriteLine($"{name} unregistered successfully");
                }
            }

            foreach (KeyValuePair<string, string> pair in parking)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
