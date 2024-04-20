int number = int.Parse(Console.ReadLine());
string result;
if (number < 100)
{
    result = "Less than 100";
}
else if (100 <= number && number <= 200)     // else if (number is <= 100 and < 200)
{
    result = "Between 100 and 200";
}
else
{
    result = "Greater than 200";
}

Console.WriteLine(result);