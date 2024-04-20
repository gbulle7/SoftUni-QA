double speed = double.Parse(Console.ReadLine());
string text;
if  (speed <= 10)
{
    text = "slow";
}
else if (speed <= 50)
{
    text = "average";
}
else if (speed <= 150)
{
    text = "fast";
}
else if (speed <= 1000)
{
    text = "ultra fast";
}
else
{
    text = "extremely fast";
}
Console.WriteLine(text);