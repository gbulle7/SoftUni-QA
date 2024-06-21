double vacationPrice = double.Parse(Console.ReadLine());
int puzzels = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double puzzelsPrice = 2.6 * puzzels;
double dollsPrice = 3 * dolls;
double bearsPrice = 4.1 * bears;
double minionsPrice = 8.2 * minions;
double trucksPrice = 2 * trucks;

double toysPrice = puzzelsPrice + dollsPrice
    + bearsPrice + minionsPrice +  trucksPrice;

if (puzzels + dolls + bears + minions + trucks >= 50)
{
    toysPrice *= 0.75;
}

double revenue = toysPrice * 0.9;    // 10% of sales paid for rent 

double difference = Math.Abs(revenue - vacationPrice);
string differenceStr = difference.ToString($"0.00");

if (revenue >= vacationPrice)
{
    Console.WriteLine($"Yes! {differenceStr} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {differenceStr} lv needed.");
}