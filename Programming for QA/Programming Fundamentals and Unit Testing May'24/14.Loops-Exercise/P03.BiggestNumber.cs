int n = int.Parse(Console.ReadLine());
int maxNumber = int.MinValue;

for  (int i = 1; i <= n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number > maxNumber)
    {
        maxNumber = number;
    }
}
Console.WriteLine(maxNumber);
