string[] arr1 = Console.ReadLine().Split(" ");
string[] arr2 = Console.ReadLine().Split(" ");
bool areIdentical = true;

for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] != arr2[i])
    {
        areIdentical = false;
	break;
    }
}
if (areIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}



/*
string a = Console.ReadLine();
string b = Console.ReadLine();
if (a  == b)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    {
        Console.WriteLine("Arrays are not identical.");
    }
}
*/