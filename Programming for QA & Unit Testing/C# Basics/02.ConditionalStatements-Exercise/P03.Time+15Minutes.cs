int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());
minute += 15;

if (minute >= 60)
{
    minute -= 60;
    hour += 1;
}

if (hour > 23)
{
    hour -= 24;
}

Console.WriteLine($"{hour}:{minute:00}");