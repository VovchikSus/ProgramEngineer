using System;

namespace Labratory2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Track Caddilac = new Track("Caddilac", 3.45, false);
            Console.WriteLine(Caddilac.ToString());
            
            Track PrettyFar = new Track("Pretty far", 1.45, true);
            Console.WriteLine(PrettyFar.ToString());
            
            
            AlbumList<MusicBase> SpiritualyAndDistortion = new AlbumList<MusicBase>(){
                new Track("Downgrade Desert",4.23,false),
                new Track("Nervous Waltz",3.23,false),
                new Track("Very Noise",1.47,false),
                new Track("Hollow Tree",3.06,false),
                new Track("Camel Dancefloor",3.13,false),
                new Track("Parpaing",2.18,false),
            };
        }
    }
}