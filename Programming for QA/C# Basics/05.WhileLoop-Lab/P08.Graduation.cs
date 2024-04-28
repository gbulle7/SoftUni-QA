string name = Console.ReadLine();
double totalScore = 0;
int year = 1;
int failed = 0;

while (year <= 12)
{
    double score = double.Parse(Console.ReadLine());
    if (score < 4)
    {
        failed++;
        if (failed == 2)
        {
            Console.WriteLine($"{name} has been excluded at {year} grade");
            break;
        }
        continue;
    }
    totalScore += score;
    year += 1;
}
if (year > 12)
{
    Console.WriteLine($"{name} graduated. Average grade: {(totalScore/12):F2}");
}