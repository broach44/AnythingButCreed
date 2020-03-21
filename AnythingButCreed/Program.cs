using System;
using System.Collections.Generic;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var creedSong1 = new Song("Creed", "Arms Wide Open");
            var creedSong2 = new Song("Creed", "My Own Prison");
            var coheedSong1 = new Song("Coheed and Cambria", "Blood Red Summer");
            var coheedSong2 = new Song("Coheed and Cambria", "Pearl of the Stars");
            var museSong1 = new Song("Muse", "Black Holes and Revelations");
            var museSong2 = new Song("Muse", "Knights of Cedonia");
            var aerosmithSong1 = new Song("Aerosmith", "Pink");
            var aerosmithSong2 = new Song("Aerosmith", "Walk This Way");
            var aerosmithSong3 = new Song("Aerosmith", "Janie's Got a Gun");
            var aerosmithSong4 = new Song("Aerosmith", "Back in the Saddle Again");
            var metallicaSong1 = new Song("Metallica", "Unforgiven");
            var metallicaSong2 = new Song("Metallica", "Fuel");

            var goodSongs = new List<Song>();

            var allSongs = new List<Song>()
            {
                creedSong1,
                creedSong2,
                coheedSong1,
                coheedSong2,
                museSong1,
                museSong2,
                aerosmithSong1,
                aerosmithSong2,
                aerosmithSong3,
                aerosmithSong4,
                metallicaSong1,
                metallicaSong2
            };

            goodSongs = allSongs.FindAll(song => song.Artist != "Creed");

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }

            Console.ReadLine();
        }
    }
}
