using System.Text;
using System.Text.RegularExpressions;

namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\+359([ -])2\1[0-9]{3}\1[0-9]{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            string result = string.Join(", ", matches);
            Console.WriteLine(result);
        }
    }
}
