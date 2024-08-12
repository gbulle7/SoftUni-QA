namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0) { throw new Exception("Invalid number."); }
                Console.WriteLine(Math.Sqrt(n));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
            
        }
    }
}