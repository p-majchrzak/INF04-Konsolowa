using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
    internal class Program
    {
        public static List<Music> ReadFromFile(string path)
        {
            List <Music> musicList = new List <Music> ();
            StreamReader readFile=new StreamReader(path);
            while (!readFile.EndOfStream)
            {
                string artist = readFile.ReadLine();
                string album = readFile.ReadLine();
                int songsNumber = int.Parse(readFile.ReadLine());
                int year =int.Parse(readFile.ReadLine());
                int downloadNumber = int.Parse(readFile.ReadLine());
                string skipLine = readFile.ReadLine();
                Music music = new Music (artist,album,songsNumber,year,downloadNumber);
                musicList.Add (music);

            }
            readFile.Close ();
            return musicList;
        }
        /***********
        Nazwa funkcji: Display
        opis funkcji: Funkcja wyswietla dane z listy, ktora zostala przekazana jako parametr funkcji
        paramtery: list - Parametr typu kolekcji struktury Music
        zwracany typ i opis: brak
        Autor: PESEL
         
         ***********/
        public static void Display(List<Music> list)
        {
            foreach (Music music in list)
            {
                Console.WriteLine(music.artist + "\n" + music.album + "\n" + music.songsNumber + "\n"+ music.year + "\n" + music.downloadNumber + "\n");
            }
        }
        static void Main(string[] args)
        {
            Display(ReadFromFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Data.txt"));
        }
    }
}
