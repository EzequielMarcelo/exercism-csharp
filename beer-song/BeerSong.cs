using System;
using System.Linq;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown) =>
        string.Join("\n\n", Enumerable.Range(0, takeDown)
                                             .Select(i => ComposeVerse(startBottles - i)));

    private static string ComposeVerse(int bottles) => bottles switch
    {
        0 => "No more bottles of beer on the wall, no more bottles of beer.\n" +
             "Go to the store and buy some more, 99 bottles of beer on the wall.",
        1 => "1 bottle of beer on the wall, 1 bottle of beer.\n" +
             "Take it down and pass it around, no more bottles of beer on the wall.",
        _ => $"{bottles} bottles of beer on the wall, {bottles} bottles of beer.\n" +
             $"Take one down and pass it around, {(bottles - 1 == 1 ? "1 bottle" : $"{bottles - 1} bottles")} of beer on the wall."
    };
}