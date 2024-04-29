int one = int.Parse(Console.ReadLine());
int two = int.Parse(Console.ReadLine());
int three = int.Parse(Console.ReadLine());

if (one < two && two < three)
{
    Console.WriteLine("Ascending");
}
else if (one > two && two > three)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}