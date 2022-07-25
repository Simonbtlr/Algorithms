using Algorithms.Sort;
using Algorithms.UnitTests.Common;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Sort;

public class QuickSortTests : TestBase
{
    [Fact]
    public void Sort_successful_case()
    {
        // Arrange
        var arr = new[] {8, 6, 9, 3, 1, 5, 2, 4, 7, 10};
        var expectedArr = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Act
        var result = QuickSort.Sort(arr);

        // Assert
        result
            .Should()
            .BeEquivalentTo(expectedArr);
    }
}