using System.Text;
using System.Text.RegularExpressions;

namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> result = new SortedDictionary<int, int>();

            foreach (int number in numbers) 
            {
                if (!result.ContainsKey(number))
                {
                    result.Add(number, 0);
                }
                result[number]++;
            }

            foreach (KeyValuePair<int, int> item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
