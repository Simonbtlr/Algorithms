namespace Algorithms.Utils;

public static class Extensions
{
    public static void PrintAll<T>(this IEnumerable<T> list)
    {
        Console.WriteLine(string.Join(", ", list));
    }
}