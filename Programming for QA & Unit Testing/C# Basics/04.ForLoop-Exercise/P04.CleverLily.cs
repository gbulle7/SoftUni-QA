int age = int.Parse(Console.ReadLine());
double wmPrice = double.Parse(Console.ReadLine());
int toyPrice =  int.Parse(Console.ReadLine());
int toys = 0;
double money = 0;
double sum = 0;


for (int i = 1; i <= age; i++)
{
    if (i % 2 != 0)
    {
        toys += 1;

    }
    else
    {
        money += 10;
        sum += money;
        sum -= 1;
    }
}

sum += toys * toyPrice;
double difference = Math.Abs(sum - wmPrice);
if (sum >= wmPrice)
{
    Console.WriteLine($"Yes! {difference:F2}");  // difference:.00 gives 8/10 in Judge
}
else
{
    Console.WriteLine($"No! {difference:F2}");  // difference:.00 gives 8/10 in Judge
}