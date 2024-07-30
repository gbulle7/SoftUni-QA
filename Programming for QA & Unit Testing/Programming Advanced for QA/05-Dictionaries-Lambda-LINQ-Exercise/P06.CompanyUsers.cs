namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split(" -> ");
                string company = data[0];
                string employee = data[1];

                if (!companyEmployees.ContainsKey(company))
                {
                    companyEmployees.Add(company, new List<string>());
                }

                List<string> employeesList = companyEmployees[company];

                if (!employeesList.Contains(employee))
                {
                    employeesList.Add(employee);
                }


                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> entry in companyEmployees)
            {
                Console.WriteLine(entry.Key);
                entry.Value.ForEach(employee => Console.WriteLine("-- " + employee));
            }
        }
    }
}
