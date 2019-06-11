using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return Enumerable.Range(0, max).Where(i =>
        {
            foreach (var item in multiples)
            {
                if (item > 0 && i % item == 0)
                {
                    return true;
                }
            }

            return false;
        }).Sum();
    }
}