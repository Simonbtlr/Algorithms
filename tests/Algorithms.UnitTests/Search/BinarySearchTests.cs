using System;
using System.Linq;
using Algorithms.Search;
using Algorithms.Sort;
using Algorithms.UnitTests.Common;
using AutoFixture;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Search;

public class BinarySearchTests : TestBase
{
    [Fact]
    public void Search_successful_case()
    {
        // Arrange
        var arr = Fixture
            .CreateMany<int>(10)
            .QuickSort()
            .ToList();

        var elementForSearch = arr[Random.Shared.Next(0, arr.Count)];
        var expectedResult = arr.IndexOf(elementForSearch);

        // Act
        var result = arr.MyBinarySearch(elementForSearch);

        // Assert
        result
            .Should()
            .Be(expectedResult);
    }
}