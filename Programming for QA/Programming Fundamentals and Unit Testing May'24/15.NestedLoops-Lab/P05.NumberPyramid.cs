int n = int.Parse(Console.ReadLine());
int lineEnd = 1;
int i = 1;

while (i <= n)
{
    for (int print = 1; print <= lineEnd; print++)
    {
        Console.Write(i + " ");
	i++;
	if (i > n)
	{
	    break;
	}
     }
     Console.WriteLine();
     lineEnd++;
}


/*
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
*/