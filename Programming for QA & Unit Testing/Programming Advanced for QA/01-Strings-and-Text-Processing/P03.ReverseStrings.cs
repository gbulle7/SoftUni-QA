namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string reversedText = "";

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedText += input[i];
                }
                
                Console.WriteLine(input + " = " + reversedText);
                input = Console.ReadLine();
            }

        }
    }
}
