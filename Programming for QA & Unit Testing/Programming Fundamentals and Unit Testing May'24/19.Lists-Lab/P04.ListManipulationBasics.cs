List<int> integers = Console.ReadLine().Split(" ")
    .Select(int.Parse).ToList();

string command =  Console.ReadLine();

while (command != "end")
{
    string[] cmd = command.Split(" ");
    if (cmd[0] == "Add")
    {
        int number = int.Parse(cmd[1]);
        integers.Add(number);
    }
    else if (cmd[0] == "Remove")
    {
        int number = int.Parse(cmd[1]);
        integers.Remove(number);
    }
    else if (cmd[0] == "RemoveAt")
    {
        int index = int.Parse(cmd[1]);
        integers.RemoveAt(index);
    }
    else if (cmd[0] == "Insert")
    {
        int number = int.Parse(cmd[1]);
        int index = int.Parse(cmd[2]);
        integers.Insert(index, number);
    }
    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", integers));