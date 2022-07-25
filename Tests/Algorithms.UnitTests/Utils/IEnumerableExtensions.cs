using System;
using System.Collections.Generic;

namespace Algorithms.Tests.Utils;

public static class Extensions
{
    public static void PrintAll<T>(this IEnumerable<T> list)
    {
        Console.WriteLine(string.Join(", ", list));
    }
}