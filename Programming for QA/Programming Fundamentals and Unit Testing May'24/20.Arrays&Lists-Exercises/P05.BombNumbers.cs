List<int> seq = Console.ReadLine().Split(" ")
.Select(int.Parse).ToList();

int[] bomb = Console.ReadLine().Split(" ")
.Select(int.Parse).ToArray();
int bombNum = bomb[0];
int bombPow = bomb[1];

for (int i = 0; i < seq.Count; i++)
{
    if (seq[i] == bombNum)
    {
        int startIndex = i - bombPow;
        int remove = bombPow + 1 + bombPow;

        if (startIndex < 0)
        {
            startIndex = 0;
        }
        if (startIndex + remove > seq.Count)
        {
            remove = seq.Count - startIndex;
        }
        seq.RemoveRange(startIndex, remove);
        i = -1;
    }
}

int sum = seq.Sum();
Console.WriteLine(sum);