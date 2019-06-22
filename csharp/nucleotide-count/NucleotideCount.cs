using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var allowedLetters = new List<char> { 'A', 'C', 'G', 'T' };
        var result = new ConcurrentDictionary<char, int>()
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        
        foreach (var letter in sequence)
        {
            if (allowedLetters.Contains(letter))
            {
                result.AddOrUpdate(letter, 1, (_, count) => count + 1);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        return result;
    }
}