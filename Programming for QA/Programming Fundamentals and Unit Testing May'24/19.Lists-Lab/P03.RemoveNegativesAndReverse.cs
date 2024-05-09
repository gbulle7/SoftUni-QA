List<int> integers = Console.ReadLine().Split(" ")
                    .Select(int.Parse)
                    .ToList();
for (int i = 0; i < integers.Count; i++) 
{
    if (integers[i] < 0) 
    {
        integers.RemoveAt(i--);
    }
}

//for (int i = integers.Count - 1; i >= 0; i--)
//{
//    if (integers[i] < 0)
//    {
//        integers.Remove(integers[i]);
//    }
//}

if (integers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    integers.Reverse();
    Console.WriteLine(string.Join(" ", integers));
}