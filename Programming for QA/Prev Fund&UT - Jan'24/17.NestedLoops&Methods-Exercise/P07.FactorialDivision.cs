static int Factorial(int number)
{
    int factorialNumber = 1;
    for (int i = number; i >= 1; i--)
    {
        factorialNumber *= i;
    }
    return factorialNumber;
}


int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());

int factorialFirst = Factorial(first);
int factorialSecond = Factorial(second);
Console.WriteLine(factorialFirst / factorialSecond);