using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var parts = phrase.Split(' ', '-');
        var result = "";

        foreach (var part in parts)
        {
            if (!string.IsNullOrWhiteSpace(part))
            {
                result += part.ToCharArray().Where(c => char.IsLetter(c)).First();
            }
        }

        return result.ToUpper();
    }
}