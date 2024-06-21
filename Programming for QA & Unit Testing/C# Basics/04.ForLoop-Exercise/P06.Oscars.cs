string actorName = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int jury = int.Parse(Console.ReadLine());
bool notEnough = true;
for (int i = 1; i <= jury; i++)
{
    string juryName = Console.ReadLine();
    double juryPoints = double.Parse(Console.ReadLine());
    points += juryName.Length * juryPoints / 2;
    if (points >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:F1}!");
        notEnough = false;
        break;
    }
}
if (notEnough)
{
    double remainingPoints = 1250.5 - points;
    Console.WriteLine($"Sorry, {actorName} you need {remainingPoints:F1} more!");
}
