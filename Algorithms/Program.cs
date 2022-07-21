using Algorithms.Math;
using Algorithms.Search;
using Algorithms.Sort;
using Algorithms.Utils;

namespace Algorithms;

public static class Program
{
    public static void Main(string[] args)
    {
        var list = new[] { 1, 3, 5, 7, 9 };

        Console.WriteLine(BinarySearch.Search(list, 3));  // 1
        Console.WriteLine(BinarySearch.Search(list, -1)); // 0

        list = new[] { 5, 3, 6, 2, 10 };

        SelectionSort.Sort(list).PrintAll();    // 2, 3, 5, 6, 10,

        list = new[] { 1, 5, 2, 6, 7, 3 };

        Console.WriteLine(MySum.Sum(list));    // 24
    }
}