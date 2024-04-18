int totalPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int hoursPerDay = totalPages / days / pagesPerHour;
Console.WriteLine(hoursPerDay);