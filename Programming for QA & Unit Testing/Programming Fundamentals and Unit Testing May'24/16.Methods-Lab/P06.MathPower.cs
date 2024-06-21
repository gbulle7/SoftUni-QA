static int Power(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int result = Power(number1, number2);
Console.WriteLine(result);