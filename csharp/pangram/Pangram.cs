using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return false;

        var alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
        var inputAsCharArray = input.ToLower().ToCharArray();

        for (var i = 0; i < alphabet.Length; i++)
        {
            if (!inputAsCharArray.Contains(alphabet[i])) return false;
        }

        return true;
    }
}
