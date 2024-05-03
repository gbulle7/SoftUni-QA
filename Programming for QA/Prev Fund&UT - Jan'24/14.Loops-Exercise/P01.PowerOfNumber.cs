int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int result = 1;

for  (int i = 1; i <= p; i++)
{
    result *= n;
}
Console.WriteLine(result);