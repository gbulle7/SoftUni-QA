List<int> seq = Console.ReadLine().Split(" ")
.Select(int.Parse).ToList();

for (int i = 0; i < seq.Count - 1; i++)
{
    int num1 = seq[i];
    int num2 = seq[i + 1];

    if (num1 == num2)
    {
        seq[i] = num1 + num2;
        seq.RemoveAt(i + 1);
        i = -1;
    }
}

Console.WriteLine(string.Join(" ", seq));