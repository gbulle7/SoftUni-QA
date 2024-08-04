namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

            string data = Console.ReadLine();

            while (data != "end")
            {
                string[] studentData = data.Split(" ");
                string firstName = studentData[0];
                string lastName = studentData[1];
                int age = int.Parse(studentData[2]);
                string city = studentData[3];
                
                Student newStudent = new Student(firstName, lastName, age, city);
                studentsList.Add(newStudent);

                data = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            foreach (Student student in studentsList.Where(x => x.HomeTown == filterCity))
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }

            public Student(string firstName, string lastName, int age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                HomeTown = homeTown;
            }
        }
    }
}
