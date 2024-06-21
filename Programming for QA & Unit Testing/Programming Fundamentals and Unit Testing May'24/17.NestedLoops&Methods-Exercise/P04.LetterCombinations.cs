char start = char.Parse(Console.ReadLine());
char end = char.Parse(Console.ReadLine());
char exclude = char.Parse(Console.ReadLine());
int count = 0;

for (char i = start; i <= end; i++)
{
    if (i == exclude) continue;
    for (char j = start; j <= end; j++)
    {
        if (j == exclude) continue;
        for (char k = start; k <= end; k++)
        {
            if (k == exclude)
            {
                continue;
            }
            count++;
            Console.Write($"{i}{j}{k} ");
        }
    }
}
Console.WriteLine();
Console.WriteLine(count);