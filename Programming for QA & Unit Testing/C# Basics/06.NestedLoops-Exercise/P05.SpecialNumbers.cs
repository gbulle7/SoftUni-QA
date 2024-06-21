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



/*
int n = int.Parse(Console.ReadLine());

            for (int i1 = 1; i1 <= 9; i1++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    for (int i3 = 1; i3 <= 9; i3++)
                    {
                        for (int i4 = 1; i4 <= 9; i4++)
                        {
                            if (n % i1 == 0 && n % i2 == 0 && n % i3 == 0 && n % i4 == 0)
                            {
                                Console.Write($"{i1}{i2}{i3}{i4} ");
                            }
                        }
                    }
                }
            }
*/