string figure = Console.ReadLine();
double a = double.Parse(Console.ReadLine());
double area = 0;

switch (figure)
{
    case "square":
        area = a * a;
        break;
    case "rectangle":
        double b = double.Parse(Console.ReadLine());
        area = a * b;
        break;
    case "circle":
        area = Math.PI * a * a;
        break;
}

Console.WriteLine($"{area:F2}");