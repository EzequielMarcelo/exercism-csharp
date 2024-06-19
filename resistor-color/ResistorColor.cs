using System;
using System.Linq;

public static class ResistorColor
{
    private enum COLORS
    {
        BLACK = 0,
        BROWN,
        RED,
        ORANGE,
        YELLOW,
        GREEN,
        BLUE,
        VIOLET,
        GREY,
        WHITE,
        MAX_COLORS
    }
    public static int ColorCode(string color) => Enum.TryParse(typeof(COLORS), color.ToUpper(), out var result)
            ? (int)result
            : throw new ArgumentException($"Invalid color name: {color}");

    public static string[] Colors() => Enum.GetValues(typeof(COLORS))
                   .Cast<COLORS>()
                   .Where(color => color != COLORS.MAX_COLORS)
                   .Select(color => color.ToString().ToLower())
                   .ToArray();
}