using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BeerSong
{
    public class BeerSongGenerator
    {
        List<string> lines;

        public BeerSongGenerator()
        {
            lines = new List<string>();
        }

        public string Verse(int number)
        {
            if (number == 0)
                VerseZero();
            else if (number == 1)
                VerseOne();
            else if (number == 2)
                VerseTwo();
            else
                VerseThreeOrLater(number);

            return BeerSong();
        }

        // I would like to test this method in isolation, not sure how yet
        internal string BeerSong() =>
            lines.Aggregate((aggregate, next) => $"{aggregate}\n{next}") + "\n";

        void VerseZero()
        {
            Add("No more bottles of beer on the wall, no more bottles of beer.");
            Add("Go to the store and buy some more, 99 bottles of beer on the wall.");
        }

        void VerseOne()
        {
            Add("1 bottle of beer on the wall, 1 bottle of beer.");
            Add("Take it down and pass it around, no more bottles of beer on the wall.");
        }

        void VerseTwo()
        {
            Add("2 bottles of beer on the wall, 2 bottles of beer.");
            Add("Take one down and pass it around, 1 bottle of beer on the wall.");
        }

        void VerseThreeOrLater(int verse)
        {
            Add($"{verse} bottles of beer on the wall, {verse} bottles of beer.");
            Add($"Take one down and pass it around, {verse - 1} bottles of beer on the wall.");
        }

        void Add(string line) =>
            lines.Add(line);

    }
}
