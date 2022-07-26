namespace Algorithms.Search.Graph;

public sealed record Person(
    bool IsSeller,
    IEnumerable<Person>? Friends);