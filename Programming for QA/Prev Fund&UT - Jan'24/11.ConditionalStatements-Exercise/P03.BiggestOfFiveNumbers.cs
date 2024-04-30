int maxNumber = int.MinValue;
for (int i = 1; i <= 5; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num > maxNumber) maxNumber = num;
}
Console.WriteLine(maxNumber);
