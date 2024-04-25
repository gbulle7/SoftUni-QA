int n = int.Parse(Console.ReadLine());

int maxNumber = int.MinValue;
int minNumber = int.MaxValue;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (maxNumber < currentNumber)
    {
        maxNumber = currentNumber;
    }
    if (minNumber > currentNumber)
    {
        minNumber = currentNumber;
    }
}

Console.WriteLine($"Max number: {maxNumber}");
Console.WriteLine($"Min number: {minNumber}");



/*
int smallest = int.MaxValue;
int biggest = int.MinValue;
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num < smallest)
    
        smallest = num;
    
    if (num > biggest) biggest = num;
}

Console.WriteLine($"Max number: {biggest}");
Console.WriteLine($"Min number: {smallest}");
*/
