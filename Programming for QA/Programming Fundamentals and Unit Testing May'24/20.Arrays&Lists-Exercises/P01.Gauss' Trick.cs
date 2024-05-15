int[] integers = Console.ReadLine().Split(" ")
    .Select(int.Parse).ToArray();
List<int> sums = new List<int>();

for (int i = 0; i < integers.Length / 2; i++)
{
    sums.Add(integers[i] + integers[integers.Length - 1 - i]);
}

if (integers.Length % 2 != 0)
{
    int midDigit = integers[integers.Length / 2];
    sums.Add(midDigit);
}

Console.WriteLine(string.Join(" ", sums));


/*
// Input
int[] inputNumbers = Console.ReadLine() // string
    .Split(' ', StringSplitOptions.RemoveEmptyEntries) // string[]
    .Select(int.Parse) // IEnumerable<int> -> Set which can be iterated
    .ToArray(); // int[]
 
int outputNumbersLength = inputNumbers.Length / 2;
if (inputNumbers.Length % 2 != 0)
{
    // Length is odd
    outputNumbersLength++;
}
//int outputNumbersLength = inputNumbers.Length % 2 == 0 ?
//    inputNumbers.Length / 2 : inputNumbers.Length + 1;
int[] outputNumbers = new int[outputNumbersLength];
 
// Act
for (int i = 0; i < outputNumbersLength; i++)
{
    if (inputNumbers.Length % 2 != 0 && 
        i == outputNumbersLength - 1)
    {
        // Take only the current element
        outputNumbers[i] = inputNumbers[i];
        break;
    }
 
    // Take first + i and last - i
    int elementA = inputNumbers[i];
    int elementB = inputNumbers[inputNumbers.Length - 1 - i];
    outputNumbers[i] = elementA + elementB;
}
 
// Output
Console.WriteLine(string.Join(" ", outputNumbers));
*/