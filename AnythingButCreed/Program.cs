using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3. Define a List, named `allSongs`, that contains 12 instances of `Song`.
            var AllSongs = CreatePlaylist();
            //  2. Define a List, named `goodSongs`, that will hold instances of `Song`. (this will need to be done in your Program class)
            // Anytime you see an angle bracket replace them with the word "of" 
            var GoodSongs = new List<Song>();

            

            // 4. Once the set is populated with 12 instances of song, use Linq to filter the allSongs list for songs where the artist is not Creed.
            // Set goodSongs equal to the filtered result.
            var noCreed = AllSongs.Where(song => song.Artist != "Creed");
            GoodSongs.AddRange(noCreed);

            // 5. Loop to print out all the good songs:

            foreach (var tune in GoodSongs)
            {
                Console.WriteLine(tune.Artist + " " + tune.Name);
            }

        }
        private static List<Song> CreatePlaylist()
        {
            var allSongs = new List<Song>();
            var badToTheBone = new Song("Michael Jackson", "BadToTheBone");
            var checkYoSelf = new Song("Ice Cube", "CheckYoSelf");

            allSongs.Add(badToTheBone);
            allSongs.Add(checkYoSelf);
            allSongs.Add(new Song("Creed", "bad song 1"));
            allSongs.Add(new Song("Creed", "bad song 2"));
            allSongs.Add(new Song("Creed", "bad song 3"));
            allSongs.Add(new Song("Creed", "bad song 4"));
            allSongs.Add(new Song("Creed", "bad song 5"));
            allSongs.Add(new Song("Creed", "bad song 6"));
            allSongs.Add(new Song("Creed", "bad song 7"));
            allSongs.Add(new Song("Creed", "bad song 8"));
            allSongs.Add(new Song("Creed", "bad song 9"));
            allSongs.Add(new Song("Creed", "bad song 10"));
            allSongs.Add(new Song("Queen", "Don't Stop Me Now"));
            allSongs.Add(new Song("Dolly Parton", "9 to 5"));

           

            

            return allSongs;




        }
    }
}
