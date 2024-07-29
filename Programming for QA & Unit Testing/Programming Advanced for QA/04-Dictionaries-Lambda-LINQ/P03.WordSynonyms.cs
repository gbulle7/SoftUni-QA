using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = new List<string>();
                }

                dictionary[word].Add(synonym);
            }

            foreach (KeyValuePair<string, List<string>> pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
            }
        }
    }
}
