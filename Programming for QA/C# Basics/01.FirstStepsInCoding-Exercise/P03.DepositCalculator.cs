double deposit = double.Parse(Console.ReadLine());
int term = int.Parse(Console.ReadLine());
double rate = double.Parse(Console.ReadLine());

double totalSum = deposit + term * ((deposit * rate * 0.01) / 12);
Console.WriteLine(totalSum);