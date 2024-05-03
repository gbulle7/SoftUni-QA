int n = int.Parse(Console.ReadLine());

int lastNum = 0;

while (true)
{
    int num = int.Parse(Console.ReadLine());
    if (num == n)
    {
        double result = lastNum * 1.2;
        Console.WriteLine(result);
        break;
    }
    lastNum = num;
}
