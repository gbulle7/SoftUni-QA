int timePlayerOne = int.Parse(Console.ReadLine());
int timePlayerTwo = int.Parse(Console.ReadLine());
int timePlayerThree = int.Parse(Console.ReadLine());

int totalTimeSec = timePlayerOne + timePlayerTwo + timePlayerThree;
int totalTimeMin = totalTimeSec / 60;
int remainingSec = totalTimeSec % 60;
Console.WriteLine($"{totalTimeMin}:{remainingSec:D2}");
// Console.WriteLine($"{totalTimeMin}:{remainingSec:00}");