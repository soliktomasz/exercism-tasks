using System;
using System.Collections.Generic;
using System.Linq;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (outputBase <= 1 || inputBase <= 1 || inputDigits.Any(d => d >= inputBase || d < 0))
        {
            throw new ArgumentException();
        }

        var convertedNumber = ConvertInputDigits(inputBase, inputDigits);

        var result = RebaseNumber(outputBase, convertedNumber);

        return result.ToArray();
    }

    /// <summary>
    /// Rebase number to new base.
    /// </summary>
    /// <param name="outputBase">The base to convert number to.</param>
    /// <param name="convertedNumber">The number to convert.</param>
    /// <returns>Rebased number.</returns>
    private static List<int> RebaseNumber(int outputBase, int convertedNumber)
    {
        var result = new List<int>();

        while (convertedNumber != 0)
        {
            var remainder = convertedNumber % outputBase;

            if (remainder > outputBase - 1)
            {
                result.Add(0);
            }
            else
            {
                result.Add(remainder);
            }

            convertedNumber /= outputBase;
        }

        result.Reverse();

        if (result.Count == 0)
        {
            result.Add(0);
        }

        return result;
    }

    /// <summary>
    /// Converts input digits to number. 
    /// </summary>
    /// <param name="inputBase">The input base used for converting./></param>
    /// <param name="inputDigits">The input digits to convert.</param>
    /// <returns>Converted number.</returns>
    private static int ConvertInputDigits(int inputBase, int[] inputDigits)
    {
        var parsedInputDigits = 0;

        for (int i = 0; i < inputDigits.Length; i++)
        {
            parsedInputDigits += inputDigits[i] * (int)Math.Pow(inputBase, inputDigits.Length - (i + 1));
        }

        return parsedInputDigits;
    }
}