using System.Text;

namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < count; i++)
            {
                string[] teamData = Console.ReadLine().Split("-");
                string creator = teamData[0];
                string teamName = teamData[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(teamName, creator);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            while (true)
            {              
                string[] data = Console.ReadLine().Split("->");
                if (data[0] == "end of assignment")
                {
                    break;
                }
                string user = data[0];
                string teamName = data[1];

                if (!teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(x => x.Members.Contains(user) || teams.Any(x => x.Creator == user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team team = teams.First(x => x.Name == teamName);
                    team.Members.Add(user);
                }
            }

            List<Team> validTeams = teams.Where(t => t.Members.Count > 0).ToList();
            List<Team> disbandTeams = teams.Where(t => t.Members.Count == 0).ToList();

            foreach (Team team in validTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(team.Name);
                sb.AppendLine($"- {team.Creator}");

                foreach (string member in team.Members.OrderBy(m => m))
                {
                    sb.AppendLine($"-- {member}");
                }

                Console.WriteLine(sb.ToString().Trim());
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in disbandTeams.OrderBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
            }
        }

        public class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }

            public Team(string name, string creator)
            {
                Name = name;
                Creator = creator;
                Members = new List<string>();
            }
        }
    }
}