using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder result = new();
        bool convertNextToUpper = false;

        foreach (char c in identifier)
        {
            if (char.IsControl(c))
            {
                result.Append("CTRL");
            }
            else if (c == ' ')
            {
                result.Append('_');
            }
            else if (c == '-')
            {
                convertNextToUpper = true;
            }
            else if (char.IsLetter(c))
            {
                if (c >= 'α' && c <= 'ω') 
                {
                    continue;
                }

                if (convertNextToUpper)
                {
                    result.Append(char.ToUpper(c));
                    convertNextToUpper = false;
                }
                else
                {
                    result.Append(c);
                }
            }
        }
        return result.ToString();
    }
}
