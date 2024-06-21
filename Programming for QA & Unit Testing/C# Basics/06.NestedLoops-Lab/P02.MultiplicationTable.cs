for (int multiplicand = 1; multiplicand <= 10; multiplicand++)
{
    for (int multiplier = 1; multiplier <= 10; multiplier++)
    {
        int result = multiplicand * multiplier;
        Console.WriteLine($"{multiplicand} * {multiplier} = {result}");
    }
}