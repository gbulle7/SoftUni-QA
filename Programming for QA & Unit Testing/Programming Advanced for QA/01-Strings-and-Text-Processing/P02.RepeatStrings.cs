namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine().Split();
            string result = "";
            foreach (string word in stringArray)
            {
                int repeatTimes = word.Length;
                for (int i = 0; i < repeatTimes; i++)
                {
                    result += word;
                }
               
            }

            Console.WriteLine(result);

        }
    }
}
