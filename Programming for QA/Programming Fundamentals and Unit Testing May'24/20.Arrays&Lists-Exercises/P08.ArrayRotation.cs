List<int> seq = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    int pop = seq[0];
    seq.RemoveAt(0);
    seq.Add(pop);
}
Console.WriteLine(string.Join(" ", seq));