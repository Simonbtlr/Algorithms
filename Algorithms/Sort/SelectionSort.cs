namespace Algorithms.Sort;

public static class SelectionSort
{
    public static List<int> Sort(List<int> list)
    {
        var sorted = new List<int>();

        while (list.Count != 0)
        {
            var smallestIndex = FindSmallest(list);
            var smallest = list[smallestIndex];
            
            sorted.Add(smallest);
            list.Remove(smallest);
        }

        return sorted;
    }

    private static int FindSmallest(List<int> list)
    {
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