using Algorithms.Search;
using Algorithms.Sort;
using Algorithms.Utils;

namespace Algorithms;

public static class Program
{
    public static void Main(string[] args)
    {
        var list = new List<int> { 1, 3, 5, 7, 9 };

        Console.WriteLine(BinarySearch.Search(list, 3));  // 1
        Console.WriteLine(BinarySearch.Search(list, -1)); // 0

        list = new List<int> { 5, 3, 6, 2, 10 };

        SelectionSort.Sort(list).PrintAll();    // 2, 3, 5, 6, 10,
    }
}