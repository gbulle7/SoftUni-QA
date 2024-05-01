using System.Runtime.InteropServices;

string command = Console.ReadLine();

int sumPrime = 0;
int sumNonPrime = 0;

while (command != "stop")
{
    int number = int.Parse(command);
    bool isPrime = true;
    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
    }
    else
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            sumPrime += number;
        }
        else
        {
            sumNonPrime += number;
        }
    }
    command = Console.ReadLine();
}
Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");