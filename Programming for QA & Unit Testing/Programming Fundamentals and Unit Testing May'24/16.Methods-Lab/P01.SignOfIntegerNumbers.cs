static void ReturnSign(int num)
{
    string result = "";
    if (num > 0)
    {
        result = $"The number {num} is positive.";
    }
    else if (num == 0)
    {
        result = $"The number {num} is zero.";
    }
    else if (num < 0)
    {
        result = $"The number {num} is negative.";
    }
    Console.WriteLine(result);
}

int n = int.Parse(Console.ReadLine());
ReturnSign(n);