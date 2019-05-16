using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
        var filteredInput = word.ToLower().Where(c => alphabet.Contains(c));

        return filteredInput.Count() == filteredInput.Distinct().Count();
    }
}
