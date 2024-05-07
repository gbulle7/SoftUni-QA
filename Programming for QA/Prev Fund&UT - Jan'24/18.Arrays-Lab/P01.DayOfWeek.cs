string[] week = {"Monday", "Tuesday", "Wednesday", 
                 "Thursday", "Friday", "Saturday", "Sunday"};

int day = int.Parse(Console.ReadLine());
if (day >= 1 && day <= 7)
{
    Console.WriteLine(week[day - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}