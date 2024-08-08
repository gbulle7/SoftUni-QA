namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer> ();
            string cmd = Console.ReadLine();

            while (cmd != "Tournament")
            {
                string[] data = cmd.Split();
                string trainerName = data[0];
                string pokemonName = data[1];
                string pokemonElement = data[2];
                int pokemonHealth = int.Parse(data[3]);
                
                Trainer currTrainer = new Trainer();
                Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                bool trainerExists = false;

                foreach (Trainer trainer in trainers)
                {
                    if (data[0] == trainer.Name)
                    {
                        trainerExists = true;
                        currTrainer = trainer;
                    }

                }

                if (trainerExists)
                {
                    currTrainer.Pokemons.Add(newPokemon);
                }
                else
                {
                    Trainer newTrainer = new Trainer(data[0]);
                    newTrainer.Pokemons.Add(newPokemon);
                    trainers.Add(newTrainer);
                }

                cmd = Console.ReadLine();
            }

            string command2 = Console.ReadLine();
            while (command2 != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    bool hasPokemon = false;

                    foreach (Pokemon pokemon in trainers[i].Pokemons)
                    {
                        if (command2 == pokemon.Element)
                            hasPokemon = true;
                    }

                    if (hasPokemon)
                        trainers[i].Badges++;
                    else
                        trainers[i].Pokemons.ForEach(p => { p.Health -= 10; });

                    trainers[i].Pokemons.RemoveAll(x => x.Health <= 0);
                }

                command2 = Console.ReadLine();
            }

            List<Trainer> sortedList = trainers.OrderByDescending(x => x.Badges).ToList();
            foreach (Trainer t in sortedList)
            {
                Console.WriteLine($"{t.Name} {t.Badges} {t.Pokemons.Count}");
            }
        }

        public class Trainer
        {
            public Trainer() { }
            public Trainer (string name)
            {
                Name = name;
                Badges = 0;
                Pokemons = new List<Pokemon> ();
            }
            public string? Name { get; set; }
            public int Badges { get; set; }
            public List<Pokemon>? Pokemons { get; set; }
        }

        public class Pokemon
        {
            public string Name { get; set; }
            public string Element { get; set; }
            public int Health { get; set; }

            public Pokemon(string name, string element, int health)
            {
                Name = name;
                Element = element;
                Health = health;
            }
        }
    }
}