using System;

namespace BeerSong
{
    public static class BeerSong
    {
        public static string Verse(int number) =>
            new VerseGenerator(number).Verse;

        public static string Verses(int begin, int end)
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}