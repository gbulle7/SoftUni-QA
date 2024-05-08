List<int> integers = Console.ReadLine().Split(" ")
    .Select(int.Parse).ToList();

string command =  Console.ReadLine();

while (command != "end")
{
    string[] cmd = command.Split(" ");
    if (cmd[0] == "Contains")
    {
        int number = int.Parse(cmd[1]);
        if (integers.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (cmd[0] == "PrintEven")
    {
        Console.WriteLine(PrintEven(integers));
    }
    else if (cmd[0] == "PrintOdd")
    {
        Console.WriteLine(PrintOdd(integers));
    }
    else if (cmd[0] == "GetSum")
    {
        Console.WriteLine(integers.Sum());
    }
    else if (cmd[0] == "Filter")
    {
        string condition = cmd[1];
        int number = int.Parse(cmd[2]);
        integers = Filter(integers, condition, number);
        
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", integers));


static string PrintEven(List<int> integers)
{
    List<int> evens = new();
    for (int i = 0; i < integers.Count; i++)
    {
        if (integers[i] % 2 == 0)
        {
            evens.Add(integers[i]);
        }
    }
    return string.Join(" ", evens);
}

static string PrintOdd(List<int> integers)
{
    List<int> odds = new();
    for (int i = 0; i < integers.Count; i++)
    {
        if (integers[i] % 2 != 0)
        {
            odds.Add(integers[i]);
        }
    }
    return string.Join(" ", odds);
}

static List<int> Filter(List<int> integers, string condition, int number)
{
    List<int> output = new List<int>();
    if (condition == "<")
    {
        for (int i = 0; i < integers.Count; i++)
        {
            if (integers[i] < number)
            {
                output.Add(integers[i]);
            }
        }
    }
    else if (condition == ">")
    {
        for (int i = 0; i < integers.Count; i++)
        {
            if (integers[i] > number)
            {
                output.Add(integers[i]);
            }
        }
    }
    else if (condition == "<=")
    {
        for (int i = 0; i < integers.Count; i++)
        {
            if (integers[i] <= number)
            {
                output.Add(integers[i]);
            }
        }
    }
    else if (condition == ">=")
    {
        for (int i = 0; i < integers.Count; i++)
        {
            if (integers[i] >= number)
            {
                output.Add(integers[i]);
            }
        }
    }

    return output;
}