// using static System.Math;	// To skip writing 'Math.' before 'Floor'
double recordSec = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double secondsPerMeter = double.Parse(Console.ReadLine());

double secondsSlowed = Math.Floor(distance / 15) * 12.5;
double currentTime = distance * secondsPerMeter + secondsSlowed;

if (currentTime < recordSec)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {currentTime:F2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {(currentTime - recordSec):F2} seconds slower.");
}