int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());


for  (int num = start; num <= end; num++)
{
    int primeCount = 0;
    for (int i = 1; i <= num; i++)  // Check if number is prime
    {
        if (num % i == 0)
        {
            primeCount++;
        }
            if (primeCount > 2)
            {
                break;
            }
    }
    if (primeCount == 2)
    {
        Console.Write(num + " ");
    }
}