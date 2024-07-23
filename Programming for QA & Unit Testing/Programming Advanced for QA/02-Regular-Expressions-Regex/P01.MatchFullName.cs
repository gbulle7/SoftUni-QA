using System.Text;
using System.Text.RegularExpressions;

namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            string result = string.Join(" ", matches);
            Console.WriteLine(result);
        }
    }
}
