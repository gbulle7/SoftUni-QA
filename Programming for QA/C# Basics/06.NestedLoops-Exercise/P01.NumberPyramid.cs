int n = int.Parse(Console.ReadLine());
int currentNum = 1;
bool isBigger = false;

for (int row = 1; row <= n; row++)
{
    for (int col = 1; col <= row; col++)
    {
        if (currentNum > n)
        {
            isBigger = true;
            break;
        }
        Console.Write($"{currentNum} ");
        currentNum += 1;
    }
    if (isBigger)
    {
        break;
    }
    Console.WriteLine();
}
