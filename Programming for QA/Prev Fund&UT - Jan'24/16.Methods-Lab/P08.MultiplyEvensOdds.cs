static int GetMultipleOfEvensAndOdds(int num)
{
    int sumEven = GetSumOfEvenDigits(num);
    int sumOdd = GetSumOfOddDigits(num);
    int product = sumEven * sumOdd;
    return product;
}
static int GetSumOfEvenDigits(int n)
{
    int sumEven = 0;
    string num = n.ToString();
    for (int i = 0; i < num.Length; i++)
    {
        int digit = int.Parse(num[i].ToString());
        if (digit % 2 == 0)
        {
            sumEven += digit;
        }
    }
    return sumEven;
}

static int GetSumOfOddDigits(int n)
{
    int sumOdd = 0;
    string num = n.ToString();
    for (int i = 0; i < num.Length; i++)
    {
        int digit = int.Parse(num[i].ToString());
        if (digit % 2 != 0)
        {
            sumOdd += digit;
        }
    }
    return sumOdd;
}

int number = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine(GetMultipleOfEvensAndOdds(number));