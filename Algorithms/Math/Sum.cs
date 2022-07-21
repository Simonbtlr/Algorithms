namespace Algorithms.Math;

public static class MySum
{
    public static int Sum(IEnumerable<int> arr)
    {
        var list = arr.ToList();

        switch (list.Count)
        {
            case 0:
                return 0;
            case 1:
                return list[0];
            default:
                var curr = list[^1];
                list.Remove(curr);

                return curr + Sum(list);
        }
    }
}