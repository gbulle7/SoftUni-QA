int n = int.Parse(Console.ReadLine());
int num = 1;

while (true)
{
    Console.WriteLine(num);
    num = 2 * num + 1;
    if (num>n) break;
}   