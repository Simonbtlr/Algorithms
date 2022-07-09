namespace Algorithms.Utils;

public static class IEnumerableExtensions
{
    public static void PrintAll<T>(this IEnumerable<T> list)
    {
        var test = string.Join(", ", list);
        Console.WriteLine(test);
    }
}