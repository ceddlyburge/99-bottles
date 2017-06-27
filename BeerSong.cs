using System;

public static class BeerSong
{
    public static string Verse(int number)
    {
        if (number == 0)
            return VerseZero();

        throw new NotImplementedException("You need to implement this function.");
    }

    private static string VerseZero() =>
        "No more bottles of beer on the wall, no more bottles of beer.\n" +
        "Go to the store and buy some more, 99 bottles of beer on the wall.\n";


    public static string Verses(int begin, int end)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}