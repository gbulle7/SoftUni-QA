namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>()); 
                    
                }
                students[name].Add(grade);
            }

            foreach (KeyValuePair<string, List<double>> pair in students)
            {
                double averageGrade = pair.Value.Average();
                if (averageGrade >= 4.5)
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value.Average():F2}");
                }
            }
        }
    }
}


// with LINQ
//namespace ProgrammingAdvancedForQA
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());

//            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

//            for (int i = 0; i < n; i++)
//            {
//                string name = Console.ReadLine();
//                double grade = double.Parse(Console.ReadLine());

//                if (!students.ContainsKey(name))
//                {
//                    students.Add(name, new List<double>()); 
                    
//                }
//                students[name].Add(grade);
//            }

//            var filteredStudents = students
//                .Where(x => x.Value.Average() >= 4.5);

//            foreach (var x in filteredStudents)
//            {
//                Console.WriteLine($"{x.Key} -> {x.Value.Average():F2}");
//            }
//        }
//    }
//}

