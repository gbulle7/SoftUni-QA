namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split();
                string firstName = data[0];
                string lastName = data[1];
                double grade = double.Parse(data[2]);
                Student newStudent = new Student(firstName, lastName, grade);
                students.Add(newStudent);
            }

            List<Student> filteredStudents = students
                .OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }
        }

    }
}







