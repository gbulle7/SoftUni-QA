int[] integers = Console.ReadLine().Split(" ")
    .Select(int.Parse).ToArray();
List<int> sums = new List<int>();

for (int i = 0; i < integers.Length / 2; i++)
{
    sums.Add(integers[i] + integers[integers.Length - 1 - i]);
}

if (integers.Length % 2 != 0)
{
    int midDigit = integers[integers.Length / 2];
    sums.Add(midDigit);
}

Console.WriteLine(string.Join(" ", sums));