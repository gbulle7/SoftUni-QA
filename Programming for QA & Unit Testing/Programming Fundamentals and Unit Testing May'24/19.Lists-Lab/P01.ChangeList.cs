List<int> integers = Console.ReadLine().Split(" ")
                    .Select(int.Parse).ToList();
string command = Console.ReadLine();

while (command != "end")
{
    string[] cmd = command.Split(" ");
    if (cmd[0] == "Delete")
    {
        int element = int.Parse(cmd[1]);
      	while (integers.Contains(element))
          {
            integers.Remove(element);
          }
    }
    else if (cmd[0] == "Insert")
    {
        int element = int.Parse(cmd[1]);
        int position = int.Parse(cmd[2]);
        integers.Insert(position, element);
    }
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", integers));
