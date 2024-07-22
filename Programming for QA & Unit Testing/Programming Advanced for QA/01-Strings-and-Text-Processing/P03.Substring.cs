namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            
            while (secondString.Contains(firstString))
            {
                secondString = secondString.Remove(secondString.IndexOf(firstString), firstString.Length);
            }

            Console.WriteLine(secondString);
        }
    }
}
