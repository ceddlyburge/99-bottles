using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace BeerSong
{
    public class VerseGenerator
    {
        readonly int verse;

        public VerseGenerator(int verse)
        {
            Contract.Requires(verse >= 0);
            Contract.Requires(verse <= 99);

            this.verse = verse;
        }

        public string Verse =>
            (verse == 0)
                ? VerseZero
                : VerseOneOrLater;

        string VerseZero =>
            $"No more bottles of beer on the wall, no more bottles of beer.\n" +
            $"Go to the store and buy some more, 99 bottles of beer on the wall.\n";

        string VerseOneOrLater =>
            $"{NumberOfBottles} of beer on the wall, {NumberOfBottles} of beer.\n" +
            $"Take {oneOrIt} down and pass it around, {OneLessBottle} of beer on the wall.\n";

        string NumberOfBottles =>
            HowManyBottles(verse);

        // I would rather call this NumberOfBottles but it clashes with the property of the same name. I could make them both overloaded methods, but then I would have brackets in VerseOneOrLater, which would make it less readable. It's a close call on which is best in cedds opinion.
        string HowManyBottles(int bottles)
        {
            if (bottles == 0)
                return "no more bottles";
            else if (bottles == 1)
                return "1 bottle";
            else
                return $"{bottles} bottles";
        }

        string oneOrIt
        {
            get
            {
                Contract.Requires(verse >= 1);

                return (verse == 1)
                    ? "it"
                    : "one";
            }
        }

        string OneLessBottle
        {
            get
            {
                Contract.Requires(verse >= 1);

                return HowManyBottles(verse - 1);
            }
        }

    }
}
