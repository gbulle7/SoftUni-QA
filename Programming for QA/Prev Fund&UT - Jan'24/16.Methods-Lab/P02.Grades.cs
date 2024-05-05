static void GradeName(double grade)
{
    string name = "";
    if (grade >= 2)
    {
        if (grade <= 2.99)
        {
            name = "Fail";
        }
        else if (grade <= 3.49)
        {
            name = "Average";
        }
        else if (grade <= 4.49)
        {
            name = "Good";
        }
        else if (grade <= 5.49)
        {
            name = "Very good";
        }
        else if (grade <= 6)
        {
            name = "Excellent";
        }
    }
    Console.WriteLine(name);
}

double grade = double.Parse(Console.ReadLine());
GradeName(grade);