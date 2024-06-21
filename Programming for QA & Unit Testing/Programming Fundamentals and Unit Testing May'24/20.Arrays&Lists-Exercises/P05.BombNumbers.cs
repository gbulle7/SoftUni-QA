List<int> seq = Console.ReadLine().Split(" ")
.Select(int.Parse).ToList();

int[] bomb = Console.ReadLine().Split(" ")
.Select(int.Parse).ToArray();
int bombNum = bomb[0];
int bombPow = bomb[1];

for (int i = 0; i < seq.Count; i++)
{
    if (seq[i] == bombNum)
    {
        int startIndex = i - bombPow;
        int remove = bombPow + 1 + bombPow;

        if (startIndex < 0)
        {
            startIndex = 0;
        }
        if (startIndex + remove > seq.Count)
        {
            remove = seq.Count - startIndex;
        }
        seq.RemoveRange(startIndex, remove);
        i = -1;
    }
}

int sum = seq.Sum();
Console.WriteLine(sum);


/*
List<int> numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
 
int[] bombArgs = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int bombNumber = bombArgs[0];
int bombPower = bombArgs[1];
 
for (int i = 0; i < numbers.Count; i++)
{
    int currentNumber = numbers[i];
    if (currentNumber == bombNumber)
    {
        // Bomb was found
        int leftIndex = i - bombPower;
        if (leftIndex < 0)
        {
            // Gone outside of the list in left direction
            leftIndex = 0;
        }
 
        int rightIndex = i + bombPower;
        if (rightIndex > numbers.Count - 1)
        {
            // Gone outside of the list in right direction
            rightIndex = numbers.Count - 1;
        }
 
        // Plus one because of the bomb itself
        int numbersToDetonate = rightIndex - leftIndex + 1;
        for (int j = 0; j < numbersToDetonate; j++)
        {
            numbers.RemoveAt(leftIndex);
        }
 
        // All other elements were shifted to the start of the current bomb
        // i should go back to the start of the current bomb
        // -1 is to compensate the i++ step of the loop
        i = leftIndex - 1;
    }
}
 
Console.WriteLine(GetSumOfListItems(numbers));
 
static int GetSumOfListItems(List<int> numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
 
    return sum;
} 
*/