using System.Text;

namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sbDigits = new StringBuilder();

            StringBuilder sbLetters = new StringBuilder();

            StringBuilder sbOthers = new StringBuilder();

            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    sbLetters.Append(character);
                }
                else if (char.IsDigit(character))
                {
                    sbDigits.Append(character);
                }
                else
                {
                    sbOthers.Append(character);
                }
            }
            Console.WriteLine(sbDigits);
            Console.WriteLine(sbLetters);
            Console.WriteLine(sbOthers);
        }
    }
}
