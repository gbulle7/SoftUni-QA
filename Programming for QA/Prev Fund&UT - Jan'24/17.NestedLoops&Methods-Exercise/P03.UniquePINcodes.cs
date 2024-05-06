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