string command = Console.ReadLine();

while (command != "End")
{
    int integer = int.Parse(command);
    int sumDigits = 0;
    while (integer > 0)
    {
        sumDigits += integer % 10;
        integer /= 10;
    }
    Console.WriteLine($"Sum of digits = {sumDigits}");
    command = Console.ReadLine();
}
Console.WriteLine("Goodbye");
