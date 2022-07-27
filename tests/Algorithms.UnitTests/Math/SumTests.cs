using System.Linq;
using Algorithms.Math;
using Algorithms.UnitTests.Common;
using AutoFixture;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Math;

public class SumTests : TestBase
{
    [Fact]
    public void Sum_successful_case()
    {
        // Arrange
        var arr = Fixture
            .CreateMany<int>()
            .ToList();
        var expectedResult = arr.Sum();

        // Act
        var result = arr.RecursiveSum();

        // Assert
        result
            .Should()
            .Be(expectedResult);
    }
}