int jury = int.Parse(Console.ReadLine());
string presentation =  Console.ReadLine();
double totalScore = 0;
int presentationNumber = 0;

while (presentation != "Finish")
{
    double totalPresentationScore = 0;
    for (int i = 1; i <= jury; i++)
    {
        double score = double.Parse(Console.ReadLine());
        totalPresentationScore += score;
        totalScore += score;
    }
    double averageScore = totalPresentationScore / jury;
    Console.WriteLine($"{presentation} - {averageScore:F2}.");
    presentationNumber++;
    presentation = Console.ReadLine();
}

double averageStudentScore = totalScore / jury / presentationNumber;
Console.WriteLine($"Student's final assessment is {averageStudentScore:F2}.");