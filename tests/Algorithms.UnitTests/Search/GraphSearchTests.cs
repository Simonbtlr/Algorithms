using System.Collections.Generic;
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

    [Fact]
    public void Dijkstras_successful_case()
    {
        // Arrange
        var graph = new Dictionary<string, Dictionary<string, float>>
        {
            {
                "start",
                new Dictionary<string, float>
                {
                    {"a", 6},
                    {"b", 2}
                }
            },
            {
                "a",
                new Dictionary<string, float>
                {
                    {"fin", 1}
                }
            },
            {
                "b",
                new Dictionary<string, float>
                {
                    {"a", 3},
                    {"fin", 5}
                }
            },
            {
                "fin",
                new Dictionary<string, float>()
            }
        };

        var costs = new Dictionary<string, float>
        {
            {
                "a",
                6
            },
            {
                "b",
                2
            },
            {
                "fin",
                float.PositiveInfinity
            }
        };

        var parents = new Dictionary<string, string>
        {
            {
                "a",
                "start"
            },
            {
                "b",
                "start"
            },
            {
                "fin",
                string.Empty
            }
        };

        var expectedPath = new Queue<string>(new[]
        {
            "start",
            "b",
            "a",
            "fin"
        });

        // Act
        var result = GraphSearch.DijkstrasAlgorithm(
            graph: graph,
            costs: costs,
            parents: parents);

        // Assert
        result
            .Should()
            .BeEquivalentTo(expectedPath);
    }
}