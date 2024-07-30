namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (string word in input)
            {
                foreach (char c in word)
                {
                    if (!map.ContainsKey(c))
                    {
                        map[c] = 0;
                    }
                    map[c]++;
                }     
            }

            foreach (KeyValuePair<char, int> kvp in map)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}


//namespace ProgrammingAdvancedForQA
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string text = Console.ReadLine();

//            Dictionary<char, int> charsCount = new Dictionary<char, int>();

//            foreach (char symbol in text)
//            {
//                if (symbol == ' ')
//                {
//                    continue;
//                }
//                if (!charsCount.ContainsKey(symbol))
//                {
//                    charsCount.Add(symbol, 1);
//                }
//                else
//                {
//                    charsCount[symbol]++;
//                }

//            }

//            foreach (KeyValuePair<char, int> entry in charsCount)
//            {
//                Console.WriteLine(entry.Key + " -> " + entry.Value);
//            }
//        }
//    }
//}

