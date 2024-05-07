int[] array1 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int[] array2 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();


foreach (int i in array1)
{
    for (int j = 0; j< array2.Length; j++)
    {
        if (i == array2[j])
        {
            Console.Write($"{i} ");
        }
    }
}

/*
string[] arr1 = Console.ReadLine().Split();
string[] arr2 = Console.ReadLine().Split();
foreach (string str in arr1)
{
    if (arr2.Contains(str))
    {
        Console.Write(str + " ");
    }
}
*/