int n = int.Parse(Console.ReadLine());
int maxNumber = 0;  // int.MinValue
int totalSum = 0;
for (int i = 0; i < n; i++)
{
    int number = int.Parse((Console.ReadLine()));
    if (number > maxNumber)
    {
        maxNumber = number;
    }
    totalSum += number;
}

totalSum -= maxNumber;
if  (totalSum == maxNumber)
{
    Console.WriteLine($"Yes\nSum = {totalSum}");
}
else
{
    int difference = Math.Abs(maxNumber - totalSum);
    Console.WriteLine($"No\nDiff = {difference}");
}