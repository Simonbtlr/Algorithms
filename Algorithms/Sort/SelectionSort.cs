namespace Algorithms.Sort;

public static class SelectionSort
{
    // O(n^2)
    public static IEnumerable<int> Sort(IEnumerable<int> arr)
    {
        var sorted = new List<int>();
        var list = arr.ToList();

        while (list.Count != 0)
        {
            var smallestIndex = FindSmallest(list);
            var smallest = list[smallestIndex];
            
            sorted.Add(smallest);
            list.Remove(smallest);
        }

        return sorted;
    }

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
}