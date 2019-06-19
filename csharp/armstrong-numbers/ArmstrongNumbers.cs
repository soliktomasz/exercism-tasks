using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var sum = 0.0;
        var intList = number.ToString().Select(digit => int.Parse(digit.ToString()));

        foreach (var item in intList)
        {
            sum += Math.Pow(item, intList.Count());
        }

        return sum == number;
    }
}