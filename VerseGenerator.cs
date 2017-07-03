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
            $"{NumberOfBottles} of beer on the wall, {numberOfBottles} of beer.\n" +
            $"Take {oneOrIt} down and pass it around, {oneLessBottle} of beer on the wall.\n";

        string NumberOfBottles =>
            HowManyBottles(verse);

        // return the number of bottles, but with the first character in lower case for use in the middle of a sentence.
        // I think the lowercase method name makes it more readable, but it does contradict usual naming conventions and is a bit non obvious.
        string numberOfBottles =>
            howManyBottles(verse);

        // I would rather call this NumberOfBottles but it clashes with the property of the same name. I could make them both overloaded methods, but then I would have brackets in VerseOneOrLater, which would make it less readable. It's a close call on which is best in cedds opinion.
        string HowManyBottles(int bottles)
        {
            if (bottles == 0)
                return "No more bottles";
            else if (bottles == 1)
                return "1 bottle";
            else
                return $"{bottles} bottles";
        }

        // return the number of bottles, but with the first character in lower case for use in the middle of a sentence.
        // I think the lowercase method name makes it more readable, but it does contradict usual naming conventions and is a bit non obvious.
        string howManyBottles(int bottles) =>
             (bottles == 0)
                ? "no more bottles"
                : HowManyBottles(bottles);

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

        string oneLessBottle
        {
            get
            {
                Contract.Requires(verse >= 1);

                return howManyBottles(verse - 1);
            }
        }

    }
}
