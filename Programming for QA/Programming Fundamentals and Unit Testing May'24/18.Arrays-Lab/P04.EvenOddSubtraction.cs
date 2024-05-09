string integers = Console.ReadLine();
int[] array = integers.Split(" ").Select(int.Parse).ToArray();
int sumEven = 0;
int sumOdd = 0;

foreach (int i in array)
{
    if (i % 2 == 0)
    {
        sumEven += i;
    }
    else
    {
        sumOdd += i;
    }
}
Console.WriteLine(sumEven - sumOdd);