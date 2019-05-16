using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (!string.IsNullOrWhiteSpace(input))
        {
            var stringAsCharArray = input.ToCharArray();
            Array.Reverse(stringAsCharArray);

            return new string(stringAsCharArray);
        }

        return string.Empty;
    }
}