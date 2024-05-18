List<int> seq = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    int pop = seq[0];
    seq.RemoveAt(0);
    seq.Add(pop);
}
Console.WriteLine(string.Join(" ", seq));

/*
int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    int tempInt = seq[0];
    for (int j = 0; j < seq.Length - 1; j++)
    {
        
        seq[j] = seq[j + 1];
    }
    seq[seq.Length - 1] = tempInt;
}

Console.WriteLine(string.Join(" ", seq));
*/