int[] seq = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
List<int> result = new List<int>();

for (int i = 0; i < seq.Length; i++)
{
    bool isTopInt = true;
    for (int j = i + 1; j < seq.Length; j++)
    {
        if (seq[i] <= seq[j])
        {
            isTopInt = false;
            break;
        }
    }
    if (isTopInt)
    {
        result.Add(result[i]);
    }
}
Console.WriteLine(string.Join(" ", result));