// Ceil
double number1 = Math.Ceiling(23.45);           // 24

// Floor
double number2 = Math.Floor(45.67);             // 45

// Abs
int number3 = Math.Abs(-50);                    // 50

// Round
double number4 = Math.Round(45.67852, 2);       // 45.68

// Format
Console.WriteLine("{0:F2}", 123.456); // 123.46

// Interpolate
double a = 123.456;
Console.WriteLine($"{a:F2}");	      // 123.46

// Difference between Round and Format
Console.WriteLine(Math.Round(45.60000, 4));     // 45.6
Console.WriteLine("{0:F4}", 45.60000);          // 45.6000