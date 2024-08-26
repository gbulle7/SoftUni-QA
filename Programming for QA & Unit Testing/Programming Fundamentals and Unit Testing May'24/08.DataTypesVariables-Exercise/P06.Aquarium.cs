int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double occupiedPercentage = double.Parse(Console.ReadLine());

int aquariumVolume = length * width * height;
double aquariumVolumeLtrs = aquariumVolume * 0.001;

double remainingLtrs = aquariumVolumeLtrs * (1 - occupiedPercentage * 0.01);
Console.WriteLine($"{remainingLtrs:F2}");