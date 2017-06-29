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
            else
                VerseTwoOrLater(number);

            return BeerSong();
        }

        // I would like to test this method in isolation, not sure how yet
        internal string BeerSong() =>
            lines.Aggregate((aggregate, next) => $"{aggregate}\n{next}") + "\n";

        string NumberOfBottles(int bottles)
        {
            if (bottles == 0)
                return "No more bottles";
            else if (bottles == 1)
                return "1 bottle";
            else
                return $"{bottles} bottles";
        }

        // return the number of bottles, but with the first character in lower case for use in the middle of a sentence.
        // I think this makes it more readable, but it does contradict usual naming conventions.
        string numberOfBottles(int bottles)
        {
            if (bottles == 0)
                return "no more bottles";
            else
                return NumberOfBottles(bottles);
        }

        void VerseZero()
        {
            Add($"{NumberOfBottles(0)} of beer on the wall, {numberOfBottles(0)} of beer.");
            Add($"Go to the store and buy some more, {numberOfBottles(99)} of beer on the wall.");
        }

        void VerseOne()
        {
            Add($"{NumberOfBottles(1)} of beer on the wall, {numberOfBottles(1)} of beer.");
            Add($"Take it down and pass it around, {numberOfBottles(0)} of beer on the wall.");
        }

        void VerseTwoOrLater(int verse)
        {
            Add($"{NumberOfBottles(verse)} of beer on the wall, {numberOfBottles(verse)} of beer.");
            Add($"Take one down and pass it around, {numberOfBottles(verse - 1)} of beer on the wall.");
        }

        void Add(string line) =>
            lines.Add(line);

    }
}
