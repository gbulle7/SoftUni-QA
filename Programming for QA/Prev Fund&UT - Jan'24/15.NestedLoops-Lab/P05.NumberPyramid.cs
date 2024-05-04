int n = int.Parse(Console.ReadLine());
int currentN = 0;
bool complete = false;

for (int row = 1; row <= n; row++)
{
    for (int col = 1; col <= row; col++)
    {	
      	if (currentN >= n)
        {
            complete = true;
            break;
        }
        currentN++;
        Console.Write($"{currentN} ");
        
    }
    if (complete)
    {
        break;
    }
    Console.WriteLine();
}
