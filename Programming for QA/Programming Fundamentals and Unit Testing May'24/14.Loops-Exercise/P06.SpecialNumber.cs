int n = int.Parse(Console.ReadLine());
int tempNum = n;
bool isSpecial = true;

while  (tempNum > 0)
{
    int divisor = tempNum % 10;
    if (n % divisor != 0)
    {
        isSpecial = false;
        break;
    }
    tempNum /= 10;
}

if (isSpecial)
{
    Console.WriteLine($"{n} is special");
}
else
{
    Console.WriteLine($"{n} is not special");
}