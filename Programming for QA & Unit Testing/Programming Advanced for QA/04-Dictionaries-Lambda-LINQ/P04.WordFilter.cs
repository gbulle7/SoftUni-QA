namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                    .Split()
                                    .Where(w => w.Length % 2 == 0)
                                    .ToArray();
            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
        }
    }
}
