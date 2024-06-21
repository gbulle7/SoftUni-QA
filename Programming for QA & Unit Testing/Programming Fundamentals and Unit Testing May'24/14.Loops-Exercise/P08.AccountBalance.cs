string command = Console.ReadLine();
double balance = 0;

while (command != "End")
{
    double money = double.Parse(command);
    if (money >= 0)
    {
        Console.WriteLine($"Increase: {money:F2}");
    }
    else
    {
        Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
    }
    balance += money;
    command = Console.ReadLine();
}
Console.WriteLine($"Balance: {balance:F2}");