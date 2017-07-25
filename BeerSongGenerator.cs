using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace BeerSong
{
    public class BeerSongGenerator
    {
        public string Verses(int begin, int end)
        {
            Contract.Requires(begin > end);
            Contract.Requires(end >= 0);
            Contract.Requires(begin <= 99);

            return string.Join("\n", VersesList(begin, end));
        }

        IEnumerable<string> VersesList(int begin, int end)
        {
            for (int verse = begin; verse >= end; verse--)
                yield return Verse(verse);
        }

        string Verse(int verse) =>
            new VerseGenerator(verse).Verse;
    }
}