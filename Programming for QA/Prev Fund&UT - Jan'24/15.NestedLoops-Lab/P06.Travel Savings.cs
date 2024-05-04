string destination = Console.ReadLine();

while (destination != "End")
{
    double budget = double.Parse(Console.ReadLine());
    double sum = 0;
    while (sum < budget)
    {
        double money = double.Parse(Console.ReadLine());
        sum += money;
        Console.WriteLine($"Collected: {sum:F2}");
    }
    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}   