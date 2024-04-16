int a = 15;
Console.WriteLine(a / 2.0);
Console.WriteLine(a / 0.0);
Console.WriteLine(0.0 / 0.0);


string firstName = Console.ReadLine();
string lastName = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string town = Console.ReadLine();
Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
