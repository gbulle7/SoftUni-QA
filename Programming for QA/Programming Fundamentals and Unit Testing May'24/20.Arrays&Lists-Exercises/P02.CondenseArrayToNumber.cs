List<int> integers = Console.ReadLine().Split(" ")
    .Select(int.Parse).ToList();
int repeat = integers.Count - 1;

for (int j = 0; j < repeat; j++)
{
    List<int> condense = new List<int>();
    for (int i = integers.Count - 1; i > 0; i--)
    {
        condense.Insert(0, (integers[i] + integers[i - 1]));
    }
    integers = condense;
}
Console.WriteLine(string.Join(" ", integers));



/*
﻿List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList(); // List from the Console

while (input.Count > 1)
{
    List<int> output = new List<int>();

    for (int i = 0; i < input.Count - 1; i++)
    {
        int num1 = input[i];
        int num2 = input[i + 1];

        int sum = num1 + num2;
        output.Add(sum);
    }
    input = output;
}

Console.WriteLine(input[0]);
*/