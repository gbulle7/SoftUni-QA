static string RepeatString(string text, int count)
{
    string output = text;
    for (int i = 1; i < count; i++)
    {
        output += text;
    }
    return output;
}

string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
string result = RepeatString(text, count);
Console.WriteLine(result);