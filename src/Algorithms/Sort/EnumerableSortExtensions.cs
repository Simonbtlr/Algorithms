namespace Algorithms.Sort;

public static class EnumerableSortExtensions
{
    public static IEnumerable<int> SelectionSort(this IEnumerable<int> source)
    {
        var list = source.ToList();

        while (list.Count != 0)
        {
            var smallestIndex = FindSmallest(list);
            var smallest = list[smallestIndex];

            yield return smallest;

            list.Remove(smallest);
        }
    }

    public static IEnumerable<int> QuickSort(this IEnumerable<int> source) =>
        SortInner(source.ToList());

    private static int FindSmallest(IEnumerable<int> arr)
    {
        var list = arr.ToList();
        var smallest = list[0];
        var smallestIndex = 0;

        for (var i = 1; i < list.Count; i++)
            if (list[i] < smallest)
            {
                smallest = list[i];
                smallestIndex = i;
            }

        return smallestIndex;
    }

    private static IEnumerable<int> SortInner(List<int> list)
    {
        switch (list.Count)
        {
            case 0:
            case 1:
                return list;
            default:
                var pivot = list.Count / 2;
                var less = list
                    .Where(x => x < list[pivot])
                    .ToList();
                var greater = list
                    .Where(x => x > list[pivot])
                    .ToList();

                var result = new List<int>();

                result.AddRange(SortInner(less));
                result.Add(list[pivot]);
                result.AddRange(SortInner(greater));

                return result;
        }
    }
}