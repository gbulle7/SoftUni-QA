int number = int.Parse(Console.ReadLine());
string num;

switch (number)
{
    case 1:
        num = "one";
        break;
    case 2:
        num = "two";
        break;
    case 3:
        num = "three";
        break;
    case 4:
        num = "four";
        break;
    case 5:
        num = "five";
        break;
    case 6:
        num = "six";
        break;
    case 7:
        num = "seven";
        break;
    case 8:
        num = "eight";
        break;
    case 9:
        num = "nine";
        break;
    default:
        num = "Out of range";
        break;
}
Console.WriteLine(num);