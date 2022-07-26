using Algorithms.Search.Graph;
using Algorithms.UnitTests.Common;
using FluentAssertions;
using Xunit;

namespace Algorithms.UnitTests.Search;

public class GraphSearchTests : TestBase
{
    [Fact]
    public void Search_successful_case()
    {
        // Arrange
        var friend1 = new Person(
            IsSeller: false,
            Friends: null);
        var expectedFriend = new Person(
            IsSeller: true,
            Friends: new[] {friend1});
        var friend2 = new Person(
            IsSeller: false,
            Friends: new[]
            {
                friend1,
                expectedFriend
            });
        var person = new Person(
            IsSeller: false,
            Friends: new[]
            {
                friend1,
                expectedFriend,
                friend2
            });

        // Act
        var result = GraphSearch.Search(person);

        // Assert
        result
            .Should()
            .BeEquivalentTo(expectedFriend);
    }

    [Fact]
    public void Search_null_successful_case()
    {
        // Arrange
        var friend1 = new Person(
            IsSeller: false,
            Friends: null);
        var friend2 = new Person(
            IsSeller: false,
            Friends: new[] {friend1});
        var friend3 = new Person(
            IsSeller: false,
            Friends: new[]
            {
                friend1,
                friend2
            });
        var person = new Person(
            IsSeller: false,
            Friends: new[]
            {
                friend1,
                friend2,
                friend3
            });

        // Act
        var result = GraphSearch.Search(person);

        // Assert
        result
            .Should()
            .BeNull();
    }
}