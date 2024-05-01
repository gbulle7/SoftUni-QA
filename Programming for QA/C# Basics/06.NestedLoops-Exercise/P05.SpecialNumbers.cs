int n = int.Parse(Console.ReadLine());

for  (int i = 1111; i <= 9999; i++)
{
    bool isSpecial = true;
    string currentNumber = i.ToString();
    for (int j = 0; j < currentNumber.Length; j++)
    {
        int digit = int.Parse(currentNumber[j].ToString());
        if (digit == 0 || n % digit != 0)
        {
            isSpecial = false;
            break;
        }
    }
    if (isSpecial)
    {
        Console.Write(currentNumber + " ");
    }
}