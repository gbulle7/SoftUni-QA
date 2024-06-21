int number = int.Parse(Console.ReadLine());
int num = 1;
for (int i = 0; i <= number; i += 2)
{
    Console.WriteLine(num);
    num = num * 2 * 2;
}


//int number = int.Parse(Console.ReadLine());
//for (int i = 0; i <= number; ++i)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(Math.Pow(2, i));
//    }
//}
