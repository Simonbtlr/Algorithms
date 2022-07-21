namespace Algorithms.Search;

public static class BinarySearch
{
    // O(Log N)
    public static int Search(IEnumerable<int> arr, int item)
    {
        var list = arr.ToList();
        var low = 0;
        var high = list.Count;

        while (low <= high)
        {
            var mid = (low + high) / 2;
            var guess = list[mid];

            if (guess == item)
                return mid;
            
            if (guess > item)
                high = mid - 1;
            else
                low = mid + 1;
        }

        return 0;
    }
}