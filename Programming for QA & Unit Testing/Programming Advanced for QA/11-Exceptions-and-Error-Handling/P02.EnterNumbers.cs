namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int START = 1;
            const int END = 100;
            int next = START;

            List<int> numbers = new List<int>();

            while (numbers.Count < 10)
            {
                try
                {
                    int number = ReadNumber(next, END);
                    numbers.Add(number);
                    next = number;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);                   
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }

        static int ReadNumber(int start, int end)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number <= start || number >= end)
                {
                    throw new ArgumentException($"Your number is not in range {start} - {end}!");
                }
                return number;
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid Number!");
            }
        }
    }
}