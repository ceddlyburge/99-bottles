using System;

public static class BeerSong
{
    public static string Verse(int number)
    {
        if (number == 0)
            return VerseZero();
        else if (number == 1)
            return VerseOne();
        else if (number == 2)
            return VerseTwo();

        throw new NotImplementedException("You need to implement this function.");
    }

    private static string VerseZero() =>
        "No more bottles of beer on the wall, no more bottles of beer.\n" +
        "Go to the store and buy some more, 99 bottles of beer on the wall.\n";

    private static string VerseOne() =>
        "1 bottle of beer on the wall, 1 bottle of beer.\n" +
        "Take it down and pass it around, no more bottles of beer on the wall.\n";

    private static string VerseTwo() =>
        "2 bottles of beer on the wall, 2 bottles of beer.\n" +
        "Take one down and pass it around, 1 bottle of beer on the wall.\n";

    public static string Verses(int begin, int end)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}