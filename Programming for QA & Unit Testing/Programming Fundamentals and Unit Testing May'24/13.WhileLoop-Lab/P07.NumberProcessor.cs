int num = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

while (command != "End")
{
    switch (command)
    {
        case "Inc":
            num++;
            break;
        case "Dec":
            num--;
            break;
    }
    command = Console.ReadLine();
}
Console.WriteLine(num);