namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int songsNumber = int.Parse(Console.ReadLine());    
            
            List<Song> songsList = new List<Song>();

            for (int i = 0; i < songsNumber; i++)
            {
                string[] songData = Console.ReadLine().Split("_");
                string type = songData[0];
                string name = songData[1];
                string time = songData[2];

                Song newSong = new Song(type, name, time);
                songsList.Add(newSong);
            }

            string output = Console.ReadLine();
            if (output == "all")
            {
                foreach (Song song in songsList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songsList
                    .Where(x => x.TypeList == output)
                    .ToList();
                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }

            //foreach (Song song in songsList)
            //{
            //    if (output == "all" || output == song.TypeList)
            //    {
            //        Console.WriteLine(song.Name);
            //    }
            //}


        }

        public class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }

            public Song(string typeList, string name, string time)
            {
                TypeList = typeList;
                Name = name;
                Time = time;
            }
        }
    }
}
