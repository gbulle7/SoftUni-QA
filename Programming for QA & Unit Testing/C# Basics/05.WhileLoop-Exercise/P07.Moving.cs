int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

int totalSpace = width * height * length;
bool haveSpace = true;

while (command != "Done")
{
    int boxes = Convert.ToInt32(command);
    totalSpace -= boxes;
    if (totalSpace < 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(totalSpace)} Cubic meters more.");
        haveSpace = false;
        break;
    }   
    command = Console.ReadLine();
}
if (haveSpace)
{
    Console.WriteLine($"{totalSpace} Cubic meters left.");
}