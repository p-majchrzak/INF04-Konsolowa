using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public struct Music
    {
        public string artist { get; set; }
        public string album { get; set; }
        public int songsNumber  { get; set; }
        public int year { get; set; }
        public int downloadNumber { get; set; }
        public Music(string artist, string album, int songsNumber, int year, int downloadNumber)
        {
            this.artist = artist;
            this.album = album;
            this.songsNumber = songsNumber;
            this.year = year;
            this.downloadNumber = downloadNumber;
        }
        
    }
}
