int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

for  (int i = n - 1; i >= 0; i--)
{
    array[i] = int.Parse(Console.ReadLine());
}

string line = string.Join(" ", array);
Console.WriteLine(line);