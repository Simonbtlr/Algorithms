namespace Algorithms.Math;

public static class EnumerableMathExtensions
{
    public static int RecursiveSum(this IEnumerable<int> source) =>
        SumInner(source.ToList());

    private static int SumInner(List<int> list)
    {
        switch (list.Count)
        {
            case 0:
                return 0;
            case 1:
                return list[0];
            default:
                var curr = list[^1];
                list.Remove(curr);

                return curr + SumInner(list);
        }
    }
}