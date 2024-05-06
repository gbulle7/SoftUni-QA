static string MultiplicationSign(int num1, int num2, int num3)
{
    string output = "";
    int negativeCounter = 0;
    if (num1 == 0 || num2 == 0 || num3 == 0)
    {
        output = "zero";
    }
    else
    {
        if (num1 < 0)
        {
            negativeCounter++;
        }
        if (num2 < 0)
        {
            negativeCounter++;
        }
        if (num3 < 0)
        {
            negativeCounter++;
        }
        if (negativeCounter == 1 || negativeCounter == 3)
        {
            output = "negative";
        }
        else
        {
            output = "positive";
        }
        
    }
    return output;
}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

Console.WriteLine(MultiplicationSign(num1, num2, num3));