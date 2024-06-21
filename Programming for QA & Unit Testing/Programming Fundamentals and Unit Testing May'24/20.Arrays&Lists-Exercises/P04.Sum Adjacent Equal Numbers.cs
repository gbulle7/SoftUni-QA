List<int> seq = Console.ReadLine().Split(" ")
.Select(int.Parse).ToList();

for (int i = 0; i < seq.Count - 1; i++)
{
    int num1 = seq[i];
    int num2 = seq[i + 1];

    if (num1 == num2)
    {
        seq[i] = num1 + num2;
        seq.RemoveAt(i + 1);
        i = -1;
    }
}

Console.WriteLine(string.Join(" ", seq));

/*
List<int> numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
 
while (true)
{
    bool hasEqualAdjacents = false;
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        int currentNumber = numbers[i];
        int nextNumber = numbers[i + 1];
 
        if (currentNumber == nextNumber)
        {
            int sum = currentNumber + nextNumber; // Sum of the equal numbers
            numbers.RemoveAt(i); // Remove the current number
            numbers.RemoveAt(i); // Remove the next number (Hint: The numbers are shifted left after the first deletion)
 
            numbers.Insert(i, sum);
 
            hasEqualAdjacents = true;
            break;
        }
    }
 
    if (!hasEqualAdjacents)
    {
        break;
    }
}
 
Console.WriteLine(string.Join(" ", numbers));
*/