double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

if (gender == 'm' && age >= 16)
{
    Console.WriteLine("Mr.");
}
else if (gender == 'm' && age < 16)
{
    Console.WriteLine("Master");
}
else if (gender == 'f' && age >= 16)
{
    Console.WriteLine("Ms.");
}
else if (gender == 'f' && age < 16)
{
    Console.WriteLine("Miss");
}


//if (gender == 'f')
//{
//    if (age >= 16)
//    {
//        Console.WriteLine("Ms.");
//    }
//    else
//    {
//        Console.WriteLine("Miss");
//    }
//}
//else if (gender == 'm')
//{
//    //TODO: check others titles – "Mr.", "Master"
//}
