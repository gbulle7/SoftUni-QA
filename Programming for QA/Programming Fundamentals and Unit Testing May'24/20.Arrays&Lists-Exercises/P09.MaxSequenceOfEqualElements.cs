int[] seq = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
List<int> result = new List<int>();
int currNum = seq[0];
int currCount = 1;
int maxCount = 1;

for (int i = 1; i < seq.Length; i++)
{
    if (seq[i] == seq[i - 1])
    {
        currCount++;
        if (currCount > maxCount)
        {
            maxCount = currCount;
            currNum = seq[i];
        }
    }
    else
    {
        currCount = 1;
    }
}

for (int i = 0; i < maxCount; i++)
{
    result.Add(currNum);
}
Console.WriteLine(string.Join(" ", result));