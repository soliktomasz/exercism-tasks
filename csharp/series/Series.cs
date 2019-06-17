using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        var numbersLength = numbers.ToCharArray().Length;

        var slices = new List<string>();

        if(sliceLength == numbersLength)
        {
            slices.Add(numbers);

            return slices.ToArray();
        }
        else if(sliceLength > numbersLength || sliceLength <= 0)
        {
            throw new ArgumentException();
        }

        for (int i = 0; i < numbersLength; i++)
        {
            if ((i + sliceLength) > numbersLength) break;

            slices.Add(numbers.Substring(i, sliceLength));
        }

        return slices.ToArray();
    }
}