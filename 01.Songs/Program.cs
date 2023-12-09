using System;
using System.Collections.Generic;

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}

class Program
{
    static void Main()
    {
        int numberOfSongs = int.Parse(Console.ReadLine());

        List<Song> songs = new List<Song>();

        for (int i = 0; i < numberOfSongs; i++)
        {
            string[] songData = Console.ReadLine().Split('_');

            Song song = new Song
            {
                TypeList = songData[0],
                Name = songData[1],
                Time = songData[2]
            };

            songs.Add(song);
        }

        string command = Console.ReadLine();

        if (command == "all")
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            foreach (Song song in songs)
            {
                if (song.TypeList == command)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
