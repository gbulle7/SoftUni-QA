string projectName = Console.ReadLine();
int numberProjects = int.Parse(Console.ReadLine());
int hours = numberProjects * 3;

Console.WriteLine($"The architect {projectName} will need {hours} hours to complete {numberProjects} project/s.");