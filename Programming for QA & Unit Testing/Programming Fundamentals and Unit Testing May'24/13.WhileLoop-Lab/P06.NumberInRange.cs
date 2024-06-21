int num = int.Parse(Console.ReadLine());

while (num < 1 || num > 100)
{
    num = int.Parse(Console.ReadLine());
}
Console.WriteLine(num);

/*
int n = int.Parse(Console.ReadLine());

while (n < 1 || n > 100)
{
    n = int.Parse(Console.ReadLine());
}
Console.WriteLine(n);
*/


/*
int n = int.Parse(Console.ReadLine());
bool isInRange = n >= 1 && n <= 100;

while (!isInRange)
{
    n = int.Parse(Console.ReadLine());
    isInRange = n >= 1 && n <= 100;
}
Console.WriteLine(n);
*/