int century = int.Parse(Console.ReadLine());
int years = century * 100;
int day = (int)(years * 365.2422);
int hours = day * 24;
int minutes = hours * 60;
Console.WriteLine($"{century} centuries = {years} years = {day} days = {hours} hours = {minutes} minutes");