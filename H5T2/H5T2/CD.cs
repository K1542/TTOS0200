using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5T2
{
    class CD
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public double Price { get; set; }
        public List<Song> songs;

        public CD (string artist, double price)
        {
            Artist = artist;
            Price = price;
            this.songs = new List<Song>();
        }

        public void AddSong (string name, int length)
        {
            songs.Add(new Song());
        }
        public override string ToString()
        {
            return "CD:\n" +
                   "-Artist: " + Artist + "\n" +
                   "-Price: " + Price.ToString("n2") + "\n" +
                   "-Songs:\n" + songs;
        }
    }
}
