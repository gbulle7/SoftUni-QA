int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int num = int.Parse(Console.ReadLine());
int combination = 0;
bool flag = false;
int i = 0;
int j = 0;
for (i = start; i <= end; i++)
{
    for (j = start; j <= end; j++)
    {
        combination++;
        if (i + j == num)
        {
            flag = true;
            break;
        }
    }
    if (flag)
    {
        break;
    }
}
if (flag)
{
    Console.WriteLine($"Combination N:{combination} ({i} + {j} = {num})");
}
else
{
    Console.WriteLine($"{combination} combinations - neither equals {num}");
}