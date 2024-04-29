int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b) Console.WriteLine("Valid Triangle");
else Console.WriteLine("Invalid Triangle");