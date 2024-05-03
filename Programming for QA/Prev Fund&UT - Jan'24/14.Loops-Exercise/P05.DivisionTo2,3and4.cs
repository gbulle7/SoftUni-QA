int n = int.Parse(Console.ReadLine());
int division2 = 0;
int division3 = 0;
int division4 = 0;

for  (int i = 1; i <= n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number % 2 == 0) division2++;
    if (number % 3 == 0) division3++;
    if (number % 4 == 0) division4++;
}
double pct2 = (double) division2 / n * 100;
double pct3 = (double) division3 / n * 100;
double pct4 = (double) division4 / n * 100;

Console.WriteLine($"{pct2:F2}%");
Console.WriteLine($"{pct3:F2}%");
Console.WriteLine($"{pct4:F2}%");