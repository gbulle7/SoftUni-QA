static void PrintTriangle(int num)
{
    //Top half
    for (int row = 1; row <= num; row++)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
    }

    //Bottom half
    for (int row = num; row >= 1; row--)
    {
        for (int col = 1; col <= row - 1; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
    }
}

int n = int.Parse(Console.ReadLine());
PrintTriangle(n);