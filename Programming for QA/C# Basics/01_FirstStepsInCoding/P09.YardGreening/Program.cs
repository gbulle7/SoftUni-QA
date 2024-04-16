double area = double.Parse(Console.ReadLine());
double priceArea = area * 7.61;
double discount = priceArea * 0.18;
double finalPrice = priceArea - discount;
Console.WriteLine($"The final price is: {finalPrice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");