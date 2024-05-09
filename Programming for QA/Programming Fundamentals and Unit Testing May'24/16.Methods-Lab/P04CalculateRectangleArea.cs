static int CalculateRectangleArea(int width, int length)
{
    return width * length;
}

int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int result = CalculateRectangleArea(width, length);
Console.WriteLine(result);