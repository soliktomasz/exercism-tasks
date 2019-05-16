using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        if (string.IsNullOrWhiteSpace(nucleotide)) return string.Empty;

        var rnaCharArray = nucleotide.ToCharArray();

        for (var i = 0; i < rnaCharArray.Length; i++)
        {
            rnaCharArray[i] = ReplaceRnaChar(rnaCharArray[i]);
        }

        return new string(rnaCharArray);
    }

    private static char ReplaceRnaChar(char charToReplace)
    {
        switch (charToReplace)
        {
            case 'G':
                return 'C';
            case 'C':
                return 'G';
            case 'T':
                return 'A';
            case 'A':
                return 'U';
            default:
                return charToReplace;
        }
    }
}