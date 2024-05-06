int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = 0; j <= n; j++)
    {
        if (i + j == n)
        {
            for (int k = 0; k <= n; k++)
            {
                for (int l = 0; l <= n; l++)
                {
                    if (k + l == n)
                    {
                        Console.Write($"{i}{j}{k}{l} ");
                    }
                }
            }
        }
    }
}