string integers = Console.ReadLine();
int[] array = integers.Split(" ").Select(int.Parse).ToArray();
int sum = array.Sum();
Console.WriteLine(sum);


/*
string integers = Console.ReadLine();
string[] items = integers.Split(" ");
int[] array = new int[items.Length];
int sum = 0;

for (int i = 0; i < items.Length; i++)
{
    sum += int.Parse(items[i]);
}

Console.WriteLine(sum);
*/