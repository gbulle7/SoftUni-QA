int balance = int.Parse(Console.ReadLine());
int withdraw = int.Parse(Console.ReadLine());
int limit = int.Parse(Console.ReadLine());

if (withdraw <= balance && withdraw <= limit)
{
    Console.WriteLine("The withdraw was successful.");
}
else if (withdraw > limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else if (withdraw > balance)
{
    Console.WriteLine("Insufficient availability.");
}