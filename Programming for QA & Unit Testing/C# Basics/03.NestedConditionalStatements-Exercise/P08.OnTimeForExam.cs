int examHr = int.Parse(Console.ReadLine());
int examMin = int.Parse(Console.ReadLine());
int arrHr = int.Parse(Console.ReadLine());
int arrMin = int.Parse(Console.ReadLine());

int examTime = examHr * 60 + examMin;
int arrTime = arrHr * 60 + arrMin;
string arrive;

if (arrTime > examTime)
{
    arrive = "Late";
}
else if (examTime - 30 <= arrTime && arrTime <= examTime)
{
    arrive = "On time";
}
else
{
    arrive = "Early";
}

Console.WriteLine(arrive);

int difference = Math.Abs(arrTime -  examTime);
int diffHr = difference / 60;
int diffMin = difference % 60;

if (difference < 60)
{
    if (arrTime > examTime)
    {
        Console.WriteLine($"{diffMin} minutes after the start");
    }
    else if (arrTime < examTime)
    {
        Console.WriteLine($"{diffMin} minutes before the start");
    }
}
else
{
    if (arrTime > examTime)
    {
        Console.WriteLine($"{diffHr}:{diffMin:00} hours after the start");
    }
    else if (arrTime < examTime)
    {
        Console.WriteLine($"{diffHr}:{diffMin:00} hours before the start");
    }
}
