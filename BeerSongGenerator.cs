using System;
using System.Diagnostics.Contracts;
using System.Text;

namespace BeerSong
{
    public class BeerSongGenerator
    {
        readonly StringBuilder verses;
        readonly int begin;
        readonly int end;

        // check that begin > end, check end >= 0, check begin <= 99
        public BeerSongGenerator(int begin, int end)
        {
            Contract.Requires(begin > end);
            Contract.Requires(end >= 0);
            Contract.Requires(begin <= 99);

            verses = new StringBuilder();
            this.begin = begin;
            this.end = end;
        }

        public string Verses()
        {
            AddFirstVerse();

            AddSubsequentVersesWithSeparater();

            return AddedVerses();
        }

        void AddFirstVerse() =>
            verses.Append(Verse(begin));

        void AddSubsequentVersesWithSeparater()
        {
            for (int verse = begin - 1; verse >= end; verse--)
            {
                AddVerseSeparater();
                AddVerse(verse);
            }
        }

        void AddVerse(int verse) =>
            verses.Append(Verse(verse));

        string Verse(int verse) =>
            new VerseGenerator(verse).Verse;

        void AddVerseSeparater() =>
            verses.Append("\n");

        string AddedVerses() =>
            verses.ToString();
    }
}