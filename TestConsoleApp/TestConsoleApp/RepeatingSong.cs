using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class Song
    {

        private string name;
        public Song NextSong { get; set; }

        public Song(string name)
        {
            this.name = name;
        }

        public bool IsInRepeatingPlaylist()
        {
            HashSet<string> hsSongs = new();

            Song next = this.NextSong;
            hsSongs.Add(this.name);

            while (next != null)
            {
                if (hsSongs.Contains(next.name)) { return true; }
                else
                {
                    hsSongs.Add(next.name);
                    next = next.NextSong;
                }
            }
            return false;
        }

        public static void Main(string[] args)
        {
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");

            first.NextSong = second;
            second.NextSong = first;

            Console.WriteLine(first.IsInRepeatingPlaylist());
        }
    }
}
