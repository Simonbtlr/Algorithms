using Algorithms.Search;

namespace Algorithms;

public static class Program
{
    public static void Main(string[] args)
    {
        var list = new[] { 1, 3, 5, 7, 9 };

        Console.WriteLine(BinarySearch.Search(list, 3));  // 1
        Console.WriteLine(BinarySearch.Search(list, -1)); // 0
    }
}