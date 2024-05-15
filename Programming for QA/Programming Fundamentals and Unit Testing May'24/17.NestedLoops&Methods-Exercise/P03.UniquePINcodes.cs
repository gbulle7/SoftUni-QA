int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for (int i = 2; i <= max1; i++)
{
    if (i % 2 == 0)
    {
        int firstDigit = i;
        int digit2max = Math.Min(max2, 7);

        for (int j = 2; j <= digit2max; j++)
        {
            bool isPrime = true;
            for (int k = 2; k < j; k++)
            {
                if (j % k == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                int secondDigit = j;
                for (int l = 2; l <= max3; l++)
                {
                    if (l % 2 == 0)
                    {
                        int thirdDigit = l;
                        Console.WriteLine($"{i}{j}{l}");
                    }
                }
            }
        }
    }
}


/*
int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());
 
// Act
for (int firstDigit = 2; firstDigit <= max1; firstDigit += 2)
{
    // First digit will always be an even number
    for (int secondDigit = 1; secondDigit <= max2; secondDigit++)
    {
        for (int thirdDigit = 2; thirdDigit <= max3; thirdDigit += 2)
        {
            // Third digit will always be an even number
            if (IsPrime(secondDigit))
            {
                Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}");
            }
        }
    }
}
 
static bool IsPrime(int number)
{
    // Case 1: Negative number -> not prime
    // Case 2: Zero Or One -> not prime
    // Case 3: >= 2 -> Can the number be divided by another number in range [2; sqrt(number) + 1]
    // Case 4: 2 -> prime
    // Subcase a: It can be divided -> not prime
    // Subcase b: It cannot be divided -> prime
    bool isPrime = true;
 
    if (number <= 1)
    {
        // Case 1,2
        isPrime = false;
    }
    else if (number > 2)
    {
        // Case 3
        int topDivider = (int)Math.Ceiling(Math.Sqrt(number));
        for (int d = 2; d <= topDivider; d++)
        {
            if (number % d == 0)
            {
                isPrime = false;
                break;
            }
        }
    }
 
    return isPrime;
}
*/