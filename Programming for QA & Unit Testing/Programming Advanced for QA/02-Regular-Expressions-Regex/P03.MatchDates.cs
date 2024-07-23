using System.Text;
using System.Text.RegularExpressions;

namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //string pattern = @"\b[0-9]{2}([.\-/])[A-Z][a-z]{2}\1[0-9]{4}\b";
            string pattern = @"(?<day>[0-9]{2})(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            
            foreach (Match date in  matches)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
