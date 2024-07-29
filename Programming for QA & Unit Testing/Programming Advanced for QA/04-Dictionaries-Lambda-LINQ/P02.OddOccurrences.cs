namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").Select(w => w.ToLower()).ToArray();
            Dictionary<string, int> occurences = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!occurences.ContainsKey(word))
                {
                    occurences[word] = 0;
                }
                occurences[word]++;
            }

            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> pair in occurences)
            {
                if (pair.Value % 2 != 0)
                {
                    // Console.Write(pair.Key + " ");
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
