int n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i += 2)
{
    for (int j = 1; j <= n; j += 2)
    {
        int product = i * j;
        Console.Write($"{i}{j}{product} ");
    }
}


/*
int n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i++)
{
    string firstPart = "";

    if (i % 2 == 0)
    {
        firstPart += i.ToString();
        for (int j = 1; j <= n; j++)
        {
            string secondPart = "";
            if (j % 2 != 0)
            {
                secondPart += j.ToString();
                string thirdPart = (i * j).ToString();
                Console.Write(firstPart + secondPart + thirdPart + " ");
            }
        }
    }
}
*/