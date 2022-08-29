using System;
using System.Collections.Generic;
using System.Linq;


namespace T03Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongsN = int.Parse(Console.ReadLine());

            List<Song> allSongs = new List<Song>();

            for (int i = 0; i < numberOfSongsN; i++)
            {

                List<string> songName = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries).ToList();

                string songType = songName[0];
                string name = songName[1];
                string songTime = songName[2];

                Song song = new Song();

                song.TypeList = songType;
                song.SongName = name;
                song.Time = songTime;

                allSongs.Add(song);

            }

            string lastCommand = Console.ReadLine();

            foreach (Song item in allSongs)
            {
                if (lastCommand == "all")
                {
                    Console.WriteLine(item.SongName);
                }
                else if (item.TypeList == lastCommand)
                {
                    Console.WriteLine(item.SongName);
                }
            }

        }

        class Song
        {

            public string TypeList { get; set; }
            public string SongName { get; set; }
            public string Time { get; set; }
            
        }

    }

}
