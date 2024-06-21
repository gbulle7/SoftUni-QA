List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> output = new List<int>();

int longerCount = Math.Max(numbers1.Count , numbers2.Count);

for (int i = 0; i < longerCount; i++)
{
    if (i < numbers1.Count)
    {
        output.Add(numbers1[i]);
    }
    
    if (i < numbers2.Count)
    {
        output.Add(numbers2[i]);
    }
}


Console.WriteLine(string.Join(" ", output));


/*
List<int> seq1 = Console.ReadLine().Split(" ")
    .Select(int.Parse).ToList();
List<int> seq2 = Console.ReadLine().Split(" ")
    .Select(int.Parse).ToList();
List<int> mergedList = new List<int>();
List<int> bigger = new List<int>();
List<int> smaller = new List<int>();

if (seq1.Count >= seq2.Count)
{
    bigger = seq1;
    smaller = seq2;
}
else
{
    bigger = seq2;
    smaller = seq1;
}

int iterateBeginning = Math.Min(seq1.Count, seq2.Count);
for (int i = 0; i < iterateBeginning; i++)
{
    mergedList.Add(seq1[i]);
    mergedList.Add(seq2[i]);
}

for (int i = smaller.Count; i < bigger.Count; i++)
{
    mergedList.Add(bigger[i]);
}

Console.WriteLine(string.Join(" ", mergedList));
*/